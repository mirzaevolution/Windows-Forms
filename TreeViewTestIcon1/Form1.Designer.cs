namespace TreeViewTestIcon1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TreeViewFolder = new System.Windows.Forms.TreeView();
            this.ImageListMain = new System.Windows.Forms.ImageList(this.components);
            this.ComboBoxDrives = new System.Windows.Forms.ComboBox();
            this.ButtonScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TreeViewFolder
            // 
            this.TreeViewFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeViewFolder.ImageIndex = 0;
            this.TreeViewFolder.ImageList = this.ImageListMain;
            this.TreeViewFolder.Location = new System.Drawing.Point(12, 62);
            this.TreeViewFolder.Name = "TreeViewFolder";
            this.TreeViewFolder.SelectedImageIndex = 0;
            this.TreeViewFolder.Size = new System.Drawing.Size(356, 434);
            this.TreeViewFolder.TabIndex = 0;
            // 
            // ImageListMain
            // 
            this.ImageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListMain.ImageStream")));
            this.ImageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListMain.Images.SetKeyName(0, "computer.ico");
            this.ImageListMain.Images.SetKeyName(1, "folder.ico");
            this.ImageListMain.Images.SetKeyName(2, "folder-open.ico");
            // 
            // ComboBoxDrives
            // 
            this.ComboBoxDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDrives.FormattingEnabled = true;
            this.ComboBoxDrives.Location = new System.Drawing.Point(12, 13);
            this.ComboBoxDrives.Name = "ComboBoxDrives";
            this.ComboBoxDrives.Size = new System.Drawing.Size(261, 24);
            this.ComboBoxDrives.TabIndex = 1;
            // 
            // ButtonScan
            // 
            this.ButtonScan.Location = new System.Drawing.Point(294, 12);
            this.ButtonScan.Name = "ButtonScan";
            this.ButtonScan.Size = new System.Drawing.Size(75, 30);
            this.ButtonScan.TabIndex = 2;
            this.ButtonScan.Text = "Scan";
            this.ButtonScan.UseVisualStyleBackColor = true;
            this.ButtonScan.Click += new System.EventHandler(this.ButtonScan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 508);
            this.Controls.Add(this.ButtonScan);
            this.Controls.Add(this.ComboBoxDrives);
            this.Controls.Add(this.TreeViewFolder);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeView Icon Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewFolder;
        private System.Windows.Forms.ImageList ImageListMain;
        private System.Windows.Forms.ComboBox ComboBoxDrives;
        private System.Windows.Forms.Button ButtonScan;
    }
}

