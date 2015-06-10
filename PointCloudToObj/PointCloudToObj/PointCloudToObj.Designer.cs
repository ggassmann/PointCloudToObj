namespace PointCloudToObj {
    partial class PointCloudToObj {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.openPointCloudDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.meshlabServerTextBox = new System.Windows.Forms.TextBox();
            this.browseForMeshlabServerButton = new System.Windows.Forms.Button();
            this.meshlabServerPathLabel = new System.Windows.Forms.Label();
            this.tabPageOutput = new System.Windows.Forms.TabPage();
            this.outputButton = new System.Windows.Forms.Button();
            this.outputInputsListBox = new System.Windows.Forms.ListBox();
            this.textboxOutputPath = new System.Windows.Forms.TextBox();
            this.buttonBrowseOutputFolder = new System.Windows.Forms.Button();
            this.buttonAddInput = new System.Windows.Forms.Button();
            this.setOutputPathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.addInputDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // openPointCloudDialog
            // 
            this.openPointCloudDialog.DefaultExt = "exe";
            this.openPointCloudDialog.FileName = "meshlabserver.exe";
            this.openPointCloudDialog.Filter = "*.exe|*.exe";
            this.openPointCloudDialog.InitialDirectory = "C:\\Program Files\\VCG\\MeshLab";
            this.openPointCloudDialog.Title = "Select meshlabserver.exe";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSettings);
            this.tabControl.Controls.Add(this.tabPageOutput);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(694, 406);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.meshlabServerPathLabel);
            this.tabPageSettings.Controls.Add(this.browseForMeshlabServerButton);
            this.tabPageSettings.Controls.Add(this.meshlabServerTextBox);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(686, 380);
            this.tabPageSettings.TabIndex = 0;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // meshlabServerTextBox
            // 
            this.meshlabServerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meshlabServerTextBox.Location = new System.Drawing.Point(147, 9);
            this.meshlabServerTextBox.Name = "meshlabServerTextBox";
            this.meshlabServerTextBox.Size = new System.Drawing.Size(452, 20);
            this.meshlabServerTextBox.TabIndex = 0;
            this.meshlabServerTextBox.Text = "?";
            // 
            // browseForMeshlabServerButton
            // 
            this.browseForMeshlabServerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseForMeshlabServerButton.Location = new System.Drawing.Point(605, 9);
            this.browseForMeshlabServerButton.Name = "browseForMeshlabServerButton";
            this.browseForMeshlabServerButton.Size = new System.Drawing.Size(75, 20);
            this.browseForMeshlabServerButton.TabIndex = 1;
            this.browseForMeshlabServerButton.Text = "Browse";
            this.browseForMeshlabServerButton.UseVisualStyleBackColor = true;
            this.browseForMeshlabServerButton.Click += new System.EventHandler(this.browseForMeshlabServerButton_Click);
            // 
            // meshlabServerPathLabel
            // 
            this.meshlabServerPathLabel.AutoSize = true;
            this.meshlabServerPathLabel.Location = new System.Drawing.Point(6, 13);
            this.meshlabServerPathLabel.Name = "meshlabServerPathLabel";
            this.meshlabServerPathLabel.Size = new System.Drawing.Size(135, 13);
            this.meshlabServerPathLabel.TabIndex = 2;
            this.meshlabServerPathLabel.Text = "meshlabserver.exe location";
            // 
            // tabPageOutput
            // 
            this.tabPageOutput.Controls.Add(this.buttonAddInput);
            this.tabPageOutput.Controls.Add(this.buttonBrowseOutputFolder);
            this.tabPageOutput.Controls.Add(this.textboxOutputPath);
            this.tabPageOutput.Controls.Add(this.outputInputsListBox);
            this.tabPageOutput.Controls.Add(this.outputButton);
            this.tabPageOutput.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutput.Name = "tabPageOutput";
            this.tabPageOutput.Size = new System.Drawing.Size(686, 380);
            this.tabPageOutput.TabIndex = 1;
            this.tabPageOutput.Text = "Output";
            this.tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // outputButton
            // 
            this.outputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputButton.Location = new System.Drawing.Point(603, 351);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 23);
            this.outputButton.TabIndex = 0;
            this.outputButton.Text = "Output";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // outputInputsListBox
            // 
            this.outputInputsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputInputsListBox.FormattingEnabled = true;
            this.outputInputsListBox.Location = new System.Drawing.Point(8, 3);
            this.outputInputsListBox.Name = "outputInputsListBox";
            this.outputInputsListBox.Size = new System.Drawing.Size(670, 342);
            this.outputInputsListBox.TabIndex = 1;
            // 
            // textboxOutputPath
            // 
            this.textboxOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxOutputPath.Location = new System.Drawing.Point(89, 353);
            this.textboxOutputPath.Name = "textboxOutputPath";
            this.textboxOutputPath.Size = new System.Drawing.Size(406, 20);
            this.textboxOutputPath.TabIndex = 2;
            this.textboxOutputPath.Text = "<Output Directory>";
            // 
            // buttonBrowseOutputFolder
            // 
            this.buttonBrowseOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseOutputFolder.Location = new System.Drawing.Point(501, 351);
            this.buttonBrowseOutputFolder.Name = "buttonBrowseOutputFolder";
            this.buttonBrowseOutputFolder.Size = new System.Drawing.Size(96, 23);
            this.buttonBrowseOutputFolder.TabIndex = 3;
            this.buttonBrowseOutputFolder.Text = "Set Output Path";
            this.buttonBrowseOutputFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseOutputFolder.Click += new System.EventHandler(this.buttonBrowseOutputFolder_Click);
            // 
            // buttonAddInput
            // 
            this.buttonAddInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddInput.Location = new System.Drawing.Point(8, 351);
            this.buttonAddInput.Name = "buttonAddInput";
            this.buttonAddInput.Size = new System.Drawing.Size(75, 23);
            this.buttonAddInput.TabIndex = 4;
            this.buttonAddInput.Text = "Add Input";
            this.buttonAddInput.UseVisualStyleBackColor = true;
            this.buttonAddInput.Click += new System.EventHandler(this.buttonAddInput_Click);
            // 
            // addInputDialog
            // 
            this.addInputDialog.FileName = "File(s)";
            this.addInputDialog.Filter = "All Known Files|*.ply;*.stl;*.obj;*.qobj;*.off;*.xyz";
            this.addInputDialog.Multiselect = true;
            this.addInputDialog.Title = "Add Input(s)";
            // 
            // PointCloudToObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 406);
            this.Controls.Add(this.tabControl);
            this.Name = "PointCloudToObj";
            this.Text = "Point Cloud To Obj";
            this.Load += new System.EventHandler(this.PointCloudToObj_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.tabPageOutput.ResumeLayout(false);
            this.tabPageOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openPointCloudDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TextBox meshlabServerTextBox;
        private System.Windows.Forms.Label meshlabServerPathLabel;
        private System.Windows.Forms.Button browseForMeshlabServerButton;
        private System.Windows.Forms.TabPage tabPageOutput;
        private System.Windows.Forms.ListBox outputInputsListBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button buttonBrowseOutputFolder;
        private System.Windows.Forms.TextBox textboxOutputPath;
        private System.Windows.Forms.Button buttonAddInput;
        private System.Windows.Forms.FolderBrowserDialog setOutputPathDialog;
        private System.Windows.Forms.OpenFileDialog addInputDialog;
    }
}