namespace FolderOrganizerApp
{
    partial class Form1
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
            this.folderButton = new System.Windows.Forms.Button();
            this.organizeButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.extButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // folderButton
            // 
            this.folderButton.Enabled = false;
            this.folderButton.Location = new System.Drawing.Point(119, 38);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(155, 41);
            this.folderButton.TabIndex = 0;
            this.folderButton.Text = "Open Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // organizeButton
            // 
            this.organizeButton.Enabled = false;
            this.organizeButton.Location = new System.Drawing.Point(119, 134);
            this.organizeButton.Name = "organizeButton";
            this.organizeButton.Size = new System.Drawing.Size(155, 40);
            this.organizeButton.TabIndex = 1;
            this.organizeButton.Text = "Organize";
            this.organizeButton.UseVisualStyleBackColor = true;
            // 
            // extButton
            // 
            this.extButton.Location = new System.Drawing.Point(119, 85);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(155, 43);
            this.extButton.TabIndex = 2;
            this.extButton.Text = "File Text";
            this.extButton.UseVisualStyleBackColor = true;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 222);
            this.Controls.Add(this.extButton);
            this.Controls.Add(this.organizeButton);
            this.Controls.Add(this.folderButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button organizeButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

