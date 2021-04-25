namespace UnrealMigrator
{
	partial class MigratorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MigratorForm));
			this.migrateButton = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.fromDirectoryButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.fromDirectoryTextBox = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.toDirectoryButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.toDirectoryTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkboxSourceCode = new System.Windows.Forms.CheckBox();
			this.checkboxInputs = new System.Windows.Forms.CheckBox();
			this.checkboxRebinding = new System.Windows.Forms.CheckBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.checkboxContent = new System.Windows.Forms.CheckBox();
			this.checkboxAPI = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.actionLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// migrateButton
			// 
			this.migrateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.migrateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.migrateButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.migrateButton.ForeColor = System.Drawing.SystemColors.Window;
			this.migrateButton.Location = new System.Drawing.Point(381, 194);
			this.migrateButton.Name = "migrateButton";
			this.migrateButton.Size = new System.Drawing.Size(148, 51);
			this.migrateButton.TabIndex = 0;
			this.migrateButton.Text = "Migrate";
			this.toolTip.SetToolTip(this.migrateButton, "Begin migrating files from \"Source Project\" to \"Target Project\"");
			this.migrateButton.UseVisualStyleBackColor = false;
			this.migrateButton.Click += new System.EventHandler(this.migrateButton_Click);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 267);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(517, 23);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.fromDirectoryButton);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.fromDirectoryTextBox);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
			this.groupBox1.Location = new System.Drawing.Point(13, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(255, 64);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Source Project";
			// 
			// fromDirectoryButton
			// 
			this.fromDirectoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.fromDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.fromDirectoryButton.Location = new System.Drawing.Point(221, 33);
			this.fromDirectoryButton.Name = "fromDirectoryButton";
			this.fromDirectoryButton.Size = new System.Drawing.Size(24, 20);
			this.fromDirectoryButton.TabIndex = 2;
			this.fromDirectoryButton.Text = "...";
			this.toolTip.SetToolTip(this.fromDirectoryButton, "Select \"Source Project\" directory. This should be the root of the project where y" +
        "our .uproject file exists.");
			this.fromDirectoryButton.UseVisualStyleBackColor = false;
			this.fromDirectoryButton.Click += new System.EventHandler(this.fromDirectoryButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 14);
			this.label1.TabIndex = 1;
			this.label1.Text = "Directory";
			// 
			// fromDirectoryTextBox
			// 
			this.fromDirectoryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.fromDirectoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fromDirectoryTextBox.Location = new System.Drawing.Point(10, 33);
			this.fromDirectoryTextBox.Name = "fromDirectoryTextBox";
			this.fromDirectoryTextBox.Size = new System.Drawing.Size(205, 20);
			this.fromDirectoryTextBox.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.toDirectoryButton);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.toDirectoryTextBox);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
			this.groupBox2.Location = new System.Drawing.Point(274, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(255, 64);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Target Project";
			// 
			// toDirectoryButton
			// 
			this.toDirectoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.toDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.toDirectoryButton.Location = new System.Drawing.Point(221, 33);
			this.toDirectoryButton.Name = "toDirectoryButton";
			this.toDirectoryButton.Size = new System.Drawing.Size(24, 20);
			this.toDirectoryButton.TabIndex = 2;
			this.toDirectoryButton.Text = "...";
			this.toolTip.SetToolTip(this.toDirectoryButton, "Select \"Target Project\" directory. This should be the root of the project where y" +
        "our .uproject file exists.");
			this.toDirectoryButton.UseVisualStyleBackColor = false;
			this.toDirectoryButton.Click += new System.EventHandler(this.toDirectoryButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.Window;
			this.label2.Location = new System.Drawing.Point(7, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 14);
			this.label2.TabIndex = 1;
			this.label2.Text = "Directory";
			// 
			// toDirectoryTextBox
			// 
			this.toDirectoryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.toDirectoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toDirectoryTextBox.Location = new System.Drawing.Point(10, 33);
			this.toDirectoryTextBox.Name = "toDirectoryTextBox";
			this.toDirectoryTextBox.Size = new System.Drawing.Size(205, 20);
			this.toDirectoryTextBox.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(12, 248);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 14);
			this.label3.TabIndex = 4;
			this.label3.Text = "Progress";
			// 
			// checkboxSourceCode
			// 
			this.checkboxSourceCode.AutoSize = true;
			this.checkboxSourceCode.Checked = true;
			this.checkboxSourceCode.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkboxSourceCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkboxSourceCode.ForeColor = System.Drawing.SystemColors.Window;
			this.checkboxSourceCode.Location = new System.Drawing.Point(10, 19);
			this.checkboxSourceCode.Name = "checkboxSourceCode";
			this.checkboxSourceCode.Size = new System.Drawing.Size(125, 18);
			this.checkboxSourceCode.TabIndex = 5;
			this.checkboxSourceCode.Text = "Migrate Source Code";
			this.toolTip.SetToolTip(this.checkboxSourceCode, "Migrate sources C++ files from the \"Source Project\" to the \"Target Project\"");
			this.checkboxSourceCode.UseVisualStyleBackColor = true;
			// 
			// checkboxInputs
			// 
			this.checkboxInputs.AutoSize = true;
			this.checkboxInputs.Checked = true;
			this.checkboxInputs.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkboxInputs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkboxInputs.ForeColor = System.Drawing.SystemColors.Window;
			this.checkboxInputs.Location = new System.Drawing.Point(10, 67);
			this.checkboxInputs.Name = "checkboxInputs";
			this.checkboxInputs.Size = new System.Drawing.Size(147, 18);
			this.checkboxInputs.TabIndex = 6;
			this.checkboxInputs.Text = "Migrate Keybinding Inputs";
			this.toolTip.SetToolTip(this.checkboxInputs, "Migrate input keybinds (DefaultInput.ini) from the \"Source Project\" to the \"Targe" +
        "t Project\"");
			this.checkboxInputs.UseVisualStyleBackColor = true;
			// 
			// checkboxRebinding
			// 
			this.checkboxRebinding.AutoSize = true;
			this.checkboxRebinding.Checked = true;
			this.checkboxRebinding.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkboxRebinding.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkboxRebinding.ForeColor = System.Drawing.SystemColors.Window;
			this.checkboxRebinding.Location = new System.Drawing.Point(236, 43);
			this.checkboxRebinding.Name = "checkboxRebinding";
			this.checkboxRebinding.Size = new System.Drawing.Size(116, 18);
			this.checkboxRebinding.TabIndex = 7;
			this.checkboxRebinding.Text = "Blueprint Rebinding";
			this.toolTip.SetToolTip(this.checkboxRebinding, "Add ActiveClassRedirects to the DefaultEngine.ini to rebind source C++ files to m" +
        "igrated Blueprint files");
			this.checkboxRebinding.UseVisualStyleBackColor = true;
			// 
			// checkboxContent
			// 
			this.checkboxContent.AutoSize = true;
			this.checkboxContent.Checked = true;
			this.checkboxContent.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkboxContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkboxContent.ForeColor = System.Drawing.SystemColors.Window;
			this.checkboxContent.Location = new System.Drawing.Point(10, 43);
			this.checkboxContent.Name = "checkboxContent";
			this.checkboxContent.Size = new System.Drawing.Size(99, 18);
			this.checkboxContent.TabIndex = 8;
			this.checkboxContent.Text = "Migrate Content";
			this.toolTip.SetToolTip(this.checkboxContent, "Migrate content files from the \"Source Project\" to the \"Target Project\"");
			this.checkboxContent.UseVisualStyleBackColor = true;
			// 
			// checkboxAPI
			// 
			this.checkboxAPI.AutoSize = true;
			this.checkboxAPI.Checked = true;
			this.checkboxAPI.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkboxAPI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkboxAPI.ForeColor = System.Drawing.SystemColors.Window;
			this.checkboxAPI.Location = new System.Drawing.Point(236, 19);
			this.checkboxAPI.Name = "checkboxAPI";
			this.checkboxAPI.Size = new System.Drawing.Size(114, 18);
			this.checkboxAPI.TabIndex = 9;
			this.checkboxAPI.Text = "Override API Name";
			this.toolTip.SetToolTip(this.checkboxAPI, "Override the {project}_API string in header files.");
			this.checkboxAPI.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.checkboxAPI);
			this.groupBox3.Controls.Add(this.checkboxContent);
			this.groupBox3.Controls.Add(this.checkboxRebinding);
			this.groupBox3.Controls.Add(this.checkboxSourceCode);
			this.groupBox3.Controls.Add(this.checkboxInputs);
			this.groupBox3.ForeColor = System.Drawing.SystemColors.Window;
			this.groupBox3.Location = new System.Drawing.Point(13, 83);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(358, 162);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Options";
			// 
			// actionLabel
			// 
			this.actionLabel.AutoSize = true;
			this.actionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(163)))), ((int)(((byte)(9)))));
			this.actionLabel.Location = new System.Drawing.Point(70, 248);
			this.actionLabel.Name = "actionLabel";
			this.actionLabel.Size = new System.Drawing.Size(0, 14);
			this.actionLabel.TabIndex = 10;
			// 
			// MigratorForm
			// 
			this.AccessibleDescription = "A tool for migrating assets from one Unreal project to another.";
			this.AccessibleName = "Unreal Migrator Tool";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
			this.ClientSize = new System.Drawing.Size(541, 302);
			this.Controls.Add(this.actionLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.migrateButton);
			this.Controls.Add(this.groupBox3);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MigratorForm";
			this.Text = "Unreal Migrator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button migrateButton;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button fromDirectoryButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox fromDirectoryTextBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button toDirectoryButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox toDirectoryTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkboxSourceCode;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.CheckBox checkboxInputs;
		private System.Windows.Forms.CheckBox checkboxRebinding;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.CheckBox checkboxContent;
		private System.Windows.Forms.CheckBox checkboxAPI;
		private System.Windows.Forms.Label actionLabel;
	}
}

