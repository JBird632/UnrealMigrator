using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System;

namespace UnrealMigrator.Models
{
	class ProjectMigrator
	{
		private string SourceDirectory;
		private string TargetDirectory;
		private bool MigrateSourceFiles;
		private bool OverrideApi;
		private bool MigrateContents;
		private bool RebindBlueprints;
		private bool MigrateInputs;
		private ProgressBar progressBar;
		private Label actionLabel;
		private int TotalFiles;
		private int MigratedFiles;

		private List<string> CPP_EXTENSION_LIST = new List<string>(new string[2] { ".cpp", ".h" });

		public ProjectMigrator(string source, string target, bool sourceFiles, bool api, bool contents, bool rebind, bool inputs)
		{
			SourceDirectory = source;
			OverrideApi = api;
			TargetDirectory = target;
			MigrateSourceFiles = sourceFiles;
			RebindBlueprints = rebind;
			MigrateInputs = inputs;
			MigrateContents = contents;
		}

		public void AttachProgressBar(ProgressBar bar, Label label)
		{
			progressBar = bar;
			actionLabel = label;
		}

		public void Migrate()
		{
			try
			{
				var projectName = GetProjectName(TargetDirectory);
				var sourceProjectName = GetProjectName(SourceDirectory);

				if (projectName == null || sourceProjectName == null)
					return;

				SetProgress("Initializing", 0);
				MigratedFiles = 0;
				TotalFiles = CountTotalFiles();

				if (MigrateSourceFiles)
					MigrateSources(projectName);

				if (MigrateContents)
					MigrateContent();

				if (MigrateInputs)
					MigrateImputFile();

				SetProgress("Done", 100);
			}
			catch (Exception error)
			{
				SetProgress("", 0);
				MessageBox.Show(error.Message, "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SetProgress(string action, int progress)
		{
			actionLabel.Text = action;
			progressBar.Value = progress;
		}

		private void MigrateSources(string projectName)
		{
			SetProgress("Migrating Sources", 0);
			var sourceDirectory = Path.Combine(SourceDirectory, "Source");
			var targetDirectory = Path.Combine(TargetDirectory, "Source");
			var sourceAPI = GetProjectApiString(sourceDirectory);
			var targetAPI = GetProjectApiString(targetDirectory);
			var classList = RecursiveCopySources(sourceDirectory, targetDirectory, sourceAPI, targetAPI);

			if (RebindBlueprints)
				AddActiveClassRedirects(projectName, classList);
		}

		private void MigrateContent()
		{
			var percentage = ((float)MigratedFiles / (float)TotalFiles) * 100.0;
			SetProgress("Migrating Content", (int)percentage);
			var sourceContentPath = Path.Combine(SourceDirectory, "Content");
			Directory.CreateDirectory(sourceContentPath);
			var targetContentPath = Path.Combine(TargetDirectory, "Content");
			Directory.CreateDirectory(targetContentPath);
			RecursiveCopyDirectory(sourceContentPath, targetContentPath);
		}

		private void MigrateImputFile()
		{
			var inputPath = Path.Combine(SourceDirectory, "Config", "Default.ini");

			if (File.Exists(inputPath))
			{
				var targetPath = Path.Combine(TargetDirectory, "Config");
				Directory.CreateDirectory(targetPath);
				var configFilePath = Path.Combine(targetPath, "DefaultInput.ini");
				File.Copy(inputPath, configFilePath, true);
			}
		}
		private void RecursiveCopyDirectory(string sourceDirectory, string targetDirectory)
		{
			var files = Directory.GetFiles(sourceDirectory, "*", System.IO.SearchOption.TopDirectoryOnly)
				.Where(file => file.ToLower().EndsWith(".uasset"));
			Directory.CreateDirectory(targetDirectory);

			foreach (var file in files)
			{
				var fileName = Path.GetFileName(file);
				var newFilePath = Path.Combine(targetDirectory, fileName);
				File.Copy(file, newFilePath, true);
				MigratedFiles++;
				var percentage = ((float)MigratedFiles / (float)TotalFiles) * 100.0;
				SetProgress("Migrating Content", (int)percentage);
			}

			var directories = Directory.GetDirectories(sourceDirectory);

			foreach (var directory in directories)
			{
				var directoryName = Path.GetFileName(directory);
				RecursiveCopyDirectory(directory, Path.Combine(targetDirectory, directoryName));
			}
		}

		private void AddActiveClassRedirects(string projectName, List<string> classList)
		{
			var tagString = "[/Script/Engine.Engine]";
			var redirectTemplate = "\n+ActiveClassRedirects=(OldClassName=\"{0}\",NewClassName=\"/Script/{1}.{0}\")";
			var redirectLines = classList.Select(className => string.Format(redirectTemplate, className, projectName));
			var linesString = string.Join("", redirectLines);
			var configDirectory = Path.Combine(TargetDirectory, "Config");
			Directory.CreateDirectory(configDirectory);
			var configFilePath = Path.Combine(configDirectory, "DefaultEngine.ini");

			if (!File.Exists(configFilePath))
				File.Create(configFilePath);

			var text = File.ReadAllText(configFilePath);

			if (text.Contains(tagString))
				text = text.Replace(tagString, string.Format("{0}{1}", tagString, linesString));
			else
				text += string.Format("\n{0}{1}", tagString, linesString);

			File.WriteAllText(configFilePath, text);
		}

		private List<string> RecursiveCopySources(string sourceDirectory, string targetDirectory, string sourceAPI, string targetAPI)
		{
			var files = Directory.GetFiles(sourceDirectory, "*", System.IO.SearchOption.TopDirectoryOnly)
				.Where(file => EndsWithExtension(file, CPP_EXTENSION_LIST));
			Directory.CreateDirectory(targetDirectory);
			var classList = new List<string>();
			var regexSelector = new Regex(@"(?<=include )(.*)(?=.generated.h)");

			foreach (var file in files)
			{
				var fileName = Path.GetFileName(file);
				var newFilePath = Path.Combine(targetDirectory, fileName);
				File.Copy(file, newFilePath, true);

				if (fileName.ToLower().EndsWith(".h"))
				{
					var text = File.ReadAllText(newFilePath);
					var match = regexSelector.Match(text);

					if (match.Success)
						classList.Add(match.Value.Replace("\"", ""));

					if (OverrideApi)
					{
						text = text.Replace(sourceAPI, targetAPI);
						File.WriteAllText(newFilePath, text);
					}
				}

				MigratedFiles++;
				var percentage = ((float)MigratedFiles / (float)TotalFiles) * 100.0;
				SetProgress("Migrating Sources", (int)percentage);
			}

			var directories = Directory.GetDirectories(sourceDirectory);

			foreach (var directory in directories)
			{
				var directoryName = Path.GetFileName(directory);
				var recurssiveClasses = RecursiveCopySources(directory, Path.Combine(targetDirectory, directoryName), sourceAPI, targetAPI);
				classList = classList.Concat(recurssiveClasses).ToList();
			}

			return classList;
		}

		private bool EndsWithExtension(string file, List<string> extensions)
		{
			return extensions == null || extensions.Any(extension => file.ToLower().EndsWith(extension));
		}

		private int CountFilesInDirectory(string directory, List<string> extensions = null)
		{
			return Directory.GetFiles(directory, "*", System.IO.SearchOption.AllDirectories)
				.Where(file => EndsWithExtension(file, extensions))
				.Count();
		}

		private int CountTotalFiles()
		{
			var total = 0;

			if (MigrateSourceFiles)
				total += CountFilesInDirectory(Path.Combine(SourceDirectory, "Source"), CPP_EXTENSION_LIST);

			if (MigrateContents)
				total += CountFilesInDirectory(Path.Combine(SourceDirectory, "Content"));

			if (MigrateInputs)
				total++;

			return total;
		}

		private string GetProjectName(string sourceDirectory)
		{
			var files = Directory.GetFiles(sourceDirectory, "*.uproject", System.IO.SearchOption.TopDirectoryOnly);

			if (files.Length == 0)
			{
				MessageBox.Show(string.Format("Missing .uproject file in directory {0}", sourceDirectory), "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			var path = files[0];
			var fileName = Path.GetFileName(path);
			return fileName.Replace(".uproject", "");
		}

		private string GetProjectApiString(string sourceDirectory)
		{
			var files = Directory.GetFiles(sourceDirectory, "*Editor.Target.cs", System.IO.SearchOption.TopDirectoryOnly);
			
			if (files.Length == 0)
			{
				MessageBox.Show("Must provide a valid Directory", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			var path = files[0];
			var fileName = Path.GetFileName(path);
			var strippedFileName = fileName.ToLower().Replace("editor.target.cs", "").ToUpper();
			return string.Format("{0}_API", strippedFileName);
		}
	}
}
