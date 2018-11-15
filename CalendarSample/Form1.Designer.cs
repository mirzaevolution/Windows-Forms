namespace CalendarSample
{
    partial class FormCalendarSample
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.MonthCalendarMain = new System.Windows.Forms.MonthCalendar();
            this.ButtonShowSelected = new System.Windows.Forms.Button();
            this.ListBoxSelectedDates = new System.Windows.Forms.ListBox();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(5, 2);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // MonthCalendarMain
            // 
            this.MonthCalendarMain.Location = new System.Drawing.Point(5, 341);
            this.MonthCalendarMain.Name = "MonthCalendarMain";
            this.MonthCalendarMain.TabIndex = 1;
            // 
            // ButtonShowSelected
            // 
            this.ButtonShowSelected.Location = new System.Drawing.Point(34, 515);
            this.ButtonShowSelected.Name = "ButtonShowSelected";
            this.ButtonShowSelected.Size = new System.Drawing.Size(75, 23);
            this.ButtonShowSelected.TabIndex = 2;
            this.ButtonShowSelected.Text = "Show";
            this.ButtonShowSelected.UseVisualStyleBackColor = true;
            this.ButtonShowSelected.Click += new System.EventHandler(this.ButtonShowSelected_Click);
            // 
            // ListBoxSelectedDates
            // 
            this.ListBoxSelectedDates.FormattingEnabled = true;
            this.ListBoxSelectedDates.Location = new System.Drawing.Point(244, 341);
            this.ListBoxSelectedDates.Name = "ListBoxSelectedDates";
            this.ListBoxSelectedDates.Size = new System.Drawing.Size(200, 238);
            this.ListBoxSelectedDates.TabIndex = 3;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(133, 515);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 4;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // FormCalendarSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 615);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ListBoxSelectedDates);
            this.Controls.Add(this.ButtonShowSelected);
            this.Controls.Add(this.MonthCalendarMain);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCalendarSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar MonthCalendarMain;
        private System.Windows.Forms.Button ButtonShowSelected;
        private System.Windows.Forms.ListBox ListBoxSelectedDates;
        private System.Windows.Forms.Button ButtonClear;
    }
}

