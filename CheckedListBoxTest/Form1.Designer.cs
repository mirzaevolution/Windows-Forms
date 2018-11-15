namespace CheckedListBoxTest
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
            this.CheckedListBoxMain = new System.Windows.Forms.CheckedListBox();
            this.ButtonSwitchToLeft = new System.Windows.Forms.Button();
            this.ListBoxMain = new System.Windows.Forms.ListBox();
            this.ButtonSwitchToRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckedListBoxMain
            // 
            this.CheckedListBoxMain.BackColor = System.Drawing.Color.Black;
            this.CheckedListBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckedListBoxMain.CheckOnClick = true;
            this.CheckedListBoxMain.ForeColor = System.Drawing.Color.Lime;
            this.CheckedListBoxMain.FormattingEnabled = true;
            this.CheckedListBoxMain.HorizontalScrollbar = true;
            this.CheckedListBoxMain.Location = new System.Drawing.Point(12, 12);
            this.CheckedListBoxMain.Name = "CheckedListBoxMain";
            this.CheckedListBoxMain.Size = new System.Drawing.Size(186, 242);
            this.CheckedListBoxMain.TabIndex = 0;
            // 
            // ButtonSwitchToLeft
            // 
            this.ButtonSwitchToLeft.Location = new System.Drawing.Point(209, 107);
            this.ButtonSwitchToLeft.Name = "ButtonSwitchToLeft";
            this.ButtonSwitchToLeft.Size = new System.Drawing.Size(50, 23);
            this.ButtonSwitchToLeft.TabIndex = 1;
            this.ButtonSwitchToLeft.Text = ">>";
            this.ButtonSwitchToLeft.UseVisualStyleBackColor = true;
            this.ButtonSwitchToLeft.Click += new System.EventHandler(this.ButtonSwitchToLeft_Click);
            // 
            // ListBoxMain
            // 
            this.ListBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxMain.FormattingEnabled = true;
            this.ListBoxMain.Location = new System.Drawing.Point(271, 12);
            this.ListBoxMain.Name = "ListBoxMain";
            this.ListBoxMain.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxMain.Size = new System.Drawing.Size(174, 249);
            this.ListBoxMain.TabIndex = 2;
            // 
            // ButtonSwitchToRight
            // 
            this.ButtonSwitchToRight.Location = new System.Drawing.Point(209, 136);
            this.ButtonSwitchToRight.Name = "ButtonSwitchToRight";
            this.ButtonSwitchToRight.Size = new System.Drawing.Size(50, 23);
            this.ButtonSwitchToRight.TabIndex = 3;
            this.ButtonSwitchToRight.Text = "<<";
            this.ButtonSwitchToRight.UseVisualStyleBackColor = true;
            this.ButtonSwitchToRight.Click += new System.EventHandler(this.ButtonSwitchToRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 274);
            this.Controls.Add(this.ButtonSwitchToRight);
            this.Controls.Add(this.ListBoxMain);
            this.Controls.Add(this.ButtonSwitchToLeft);
            this.Controls.Add(this.CheckedListBoxMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckedListBoxMain;
        private System.Windows.Forms.Button ButtonSwitchToLeft;
        private System.Windows.Forms.ListBox ListBoxMain;
        private System.Windows.Forms.Button ButtonSwitchToRight;
    }
}

