namespace DateTimePicker
{
    partial class FormDateTimePickerSample
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
            this.DateTimePickerOne = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerTwo = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerThree = new System.Windows.Forms.DateTimePicker();
            this.ButtonShowOne = new System.Windows.Forms.Button();
            this.ButtonShowTwo = new System.Windows.Forms.Button();
            this.ButtonShowThree = new System.Windows.Forms.Button();
            this.ButtonShowFour = new System.Windows.Forms.Button();
            this.DateTimePickerFour = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // DateTimePickerOne
            // 
            this.DateTimePickerOne.Location = new System.Drawing.Point(21, 32);
            this.DateTimePickerOne.Name = "DateTimePickerOne";
            this.DateTimePickerOne.ShowCheckBox = true;
            this.DateTimePickerOne.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerOne.TabIndex = 0;
            // 
            // DateTimePickerTwo
            // 
            this.DateTimePickerTwo.CustomFormat = "dd MMMM yyyy";
            this.DateTimePickerTwo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerTwo.Location = new System.Drawing.Point(21, 89);
            this.DateTimePickerTwo.Name = "DateTimePickerTwo";
            this.DateTimePickerTwo.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerTwo.TabIndex = 1;
            // 
            // DateTimePickerThree
            // 
            this.DateTimePickerThree.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePickerThree.Location = new System.Drawing.Point(132, 146);
            this.DateTimePickerThree.Name = "DateTimePickerThree";
            this.DateTimePickerThree.ShowUpDown = true;
            this.DateTimePickerThree.Size = new System.Drawing.Size(89, 20);
            this.DateTimePickerThree.TabIndex = 2;
            // 
            // ButtonShowOne
            // 
            this.ButtonShowOne.Location = new System.Drawing.Point(251, 30);
            this.ButtonShowOne.Name = "ButtonShowOne";
            this.ButtonShowOne.Size = new System.Drawing.Size(75, 23);
            this.ButtonShowOne.TabIndex = 3;
            this.ButtonShowOne.Text = "Show";
            this.ButtonShowOne.UseVisualStyleBackColor = true;
            this.ButtonShowOne.Click += new System.EventHandler(this.ButtonShowOne_Click);
            // 
            // ButtonShowTwo
            // 
            this.ButtonShowTwo.Location = new System.Drawing.Point(251, 88);
            this.ButtonShowTwo.Name = "ButtonShowTwo";
            this.ButtonShowTwo.Size = new System.Drawing.Size(75, 23);
            this.ButtonShowTwo.TabIndex = 4;
            this.ButtonShowTwo.Text = "Show";
            this.ButtonShowTwo.UseVisualStyleBackColor = true;
            this.ButtonShowTwo.Click += new System.EventHandler(this.ButtonShowTwo_Click);
            // 
            // ButtonShowThree
            // 
            this.ButtonShowThree.Location = new System.Drawing.Point(251, 144);
            this.ButtonShowThree.Name = "ButtonShowThree";
            this.ButtonShowThree.Size = new System.Drawing.Size(75, 23);
            this.ButtonShowThree.TabIndex = 5;
            this.ButtonShowThree.Text = "Show";
            this.ButtonShowThree.UseVisualStyleBackColor = true;
            this.ButtonShowThree.Click += new System.EventHandler(this.ButtonShowThree_Click);
            // 
            // ButtonShowFour
            // 
            this.ButtonShowFour.Location = new System.Drawing.Point(251, 198);
            this.ButtonShowFour.Name = "ButtonShowFour";
            this.ButtonShowFour.Size = new System.Drawing.Size(75, 23);
            this.ButtonShowFour.TabIndex = 7;
            this.ButtonShowFour.Text = "Show";
            this.ButtonShowFour.UseVisualStyleBackColor = true;
            this.ButtonShowFour.Click += new System.EventHandler(this.ButtonShowFour_Click);
            // 
            // DateTimePickerFour
            // 
            this.DateTimePickerFour.CustomFormat = "dd MMMM yyyy hh:mm:ss tt";
            this.DateTimePickerFour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerFour.Location = new System.Drawing.Point(21, 200);
            this.DateTimePickerFour.Name = "DateTimePickerFour";
            this.DateTimePickerFour.ShowUpDown = true;
            this.DateTimePickerFour.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerFour.TabIndex = 6;
            // 
            // FormDateTimePickerSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 252);
            this.Controls.Add(this.ButtonShowFour);
            this.Controls.Add(this.DateTimePickerFour);
            this.Controls.Add(this.ButtonShowThree);
            this.Controls.Add(this.ButtonShowTwo);
            this.Controls.Add(this.ButtonShowOne);
            this.Controls.Add(this.DateTimePickerThree);
            this.Controls.Add(this.DateTimePickerTwo);
            this.Controls.Add(this.DateTimePickerOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDateTimePickerSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimePicker Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerOne;
        private System.Windows.Forms.DateTimePicker DateTimePickerTwo;
        private System.Windows.Forms.DateTimePicker DateTimePickerThree;
        private System.Windows.Forms.Button ButtonShowOne;
        private System.Windows.Forms.Button ButtonShowTwo;
        private System.Windows.Forms.Button ButtonShowThree;
        private System.Windows.Forms.Button ButtonShowFour;
        private System.Windows.Forms.DateTimePicker DateTimePickerFour;
    }
}

