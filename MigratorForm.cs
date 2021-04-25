using System;
using System.Windows.Forms;
using UnrealMigrator.Models;
using System.IO;

namespace UnrealMigrator
{
	public partial class MigratorForm : Form
	{
		public MigratorForm()
		{
			InitializeComponent();
		}

		private void migrateButton_Click(object sender, EventArgs e)
		{
			var sourceDirectory = fromDirectoryTextBox.Text;
			var targetDirectory = toDirectoryTextBox.Text;

			if (sourceDirectory == string.Empty || !Directory.Exists(sourceDirectory))
			{
				MessageBox.Show("Must provide a valid Source Directory", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (targetDirectory == string.Empty || !Directory.Exists(targetDirectory))
			{
				MessageBox.Show("Must provide a valid Target Directory", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var migrator = new ProjectMigrator(
				fromDirectoryTextBox.Text,
				toDirectoryTextBox.Text,
				checkboxSourceCode.Checked,
				checkboxAPI.Checked,
				checkboxContent.Checked,
				checkboxRebinding.Checked,
				checkboxInputs.Checked
			);

			migrator.AttachProgressBar(progressBar, actionLabel);
			migrator.Migrate();
		}

		private void fromDirectoryButton_Click(object sender, EventArgs e)
		{
			var result = folderBrowserDialog.ShowDialog();

			if (result == DialogResult.OK)
				fromDirectoryTextBox.Text = folderBrowserDialog.SelectedPath;
		}

		private void toDirectoryButton_Click(object sender, EventArgs e)
		{
			var result = folderBrowserDialog.ShowDialog();

			if (result == DialogResult.OK)
				toDirectoryTextBox.Text = folderBrowserDialog.SelectedPath;
		}
	}
}
