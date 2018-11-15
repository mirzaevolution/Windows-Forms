namespace MaskedTextBoxTest
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
            this.MaskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.ButtonShowPhoneNumber = new System.Windows.Forms.Button();
            this.ButtonShow5Nums = new System.Windows.Forms.Button();
            this.MaskedTextBox5Nums = new System.Windows.Forms.MaskedTextBox();
            this.ButtonShowShortDate = new System.Windows.Forms.Button();
            this.MaskedTextBoxShortDate = new System.Windows.Forms.MaskedTextBox();
            this.ButtonShowShortDateTime = new System.Windows.Forms.Button();
            this.MaskedTextBoxShortDateTime = new System.Windows.Forms.MaskedTextBox();
            this.ButtonShowSSN = new System.Windows.Forms.Button();
            this.MaskedTextBoxSSN = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MaskedTextBoxPhoneNumber
            // 
            this.MaskedTextBoxPhoneNumber.Location = new System.Drawing.Point(133, 14);
            this.MaskedTextBoxPhoneNumber.Mask = "(999) 000-0000";
            this.MaskedTextBoxPhoneNumber.Name = "MaskedTextBoxPhoneNumber";
            this.MaskedTextBoxPhoneNumber.Size = new System.Drawing.Size(159, 20);
            this.MaskedTextBoxPhoneNumber.TabIndex = 0;
            // 
            // ButtonShowPhoneNumber
            // 
            this.ButtonShowPhoneNumber.Location = new System.Drawing.Point(303, 12);
            this.ButtonShowPhoneNumber.Name = "ButtonShowPhoneNumber";
            this.ButtonShowPhoneNumber.Size = new System.Drawing.Size(75, 23);
            this.ButtonShowPhoneNumber.TabIndex = 4;
            this.ButtonShowPhoneNumber.Text = "Show";
            this.ButtonShowPhoneNumber.UseVisualStyleBackColor = true;
            this.ButtonShowPhoneNumber.Click += new System.EventHandler(this.ButtonShowPhoneNumber_Click);
            // 
            // ButtonShow5Nums
            // 
            this.ButtonShow5Nums.Location = new System.Drawing.Point(303, 49);
            this.ButtonShow5Nums.Name = "ButtonShow5Nums";
            this.ButtonShow5Nums.Size = new System.Drawing.Size(75, 23);
            this.ButtonShow5Nums.TabIndex = 6;
            this.ButtonShow5Nums.Text = "Show";
            this.ButtonShow5Nums.UseVisualStyleBackColor = true;
            this.ButtonShow5Nums.Click += new System.EventHandler(this.ButtonShow5Nums_Click);
            // 
            // MaskedTextBox5Nums
            // 
            this.MaskedTextBox5Nums.Location = new System.Drawing.Point(133, 51);
            this.MaskedTextBox5Nums.Mask = "00000";
            this.MaskedTextBox5Nums.Name = "MaskedTextBox5Nums";
            this.MaskedTextBox5Nums.Size = new System.Drawing.Size(159, 20);
            this.MaskedTextBox5Nums.TabIndex = 5;
            this.MaskedTextBox5Nums.ValidatingType = typeof(int);
            // 
            // ButtonShowShortDate
            // 
            this.ButtonShowShortDate.Location = new System.Drawing.Point(303, 87);
            this.ButtonShowShortDate.Name = "ButtonShowShortDate";
            this.ButtonShowShortDate.Size = new System.Drawing.Size(75, 23);
            this.ButtonShowShortDate.TabIndex = 8;
            this.ButtonShowShortDate.Text = "Show";
            this.ButtonShowShortDate.UseVisualStyleBackColor = true;
            this.ButtonShowShortDate.Click += new System.EventHandler(this.ButtonShowShortDate_Click);
            // 
            // MaskedTextBoxShortDate
            // 
            this.MaskedTextBoxShortDate.Location = new System.Drawing.Point(133, 89);
            this.MaskedTextBoxShortDate.Mask = "00/00/0000";
            this.MaskedTextBoxShortDate.Name = "MaskedTextBoxShortDate";
            this.MaskedTextBoxShortDate.Size = new System.Drawing.Size(159, 20);
            this.MaskedTextBoxShortDate.TabIndex = 7;
            this.MaskedTextBoxShortDate.ValidatingType = typeof(System.DateTime);
            // 
            // ButtonShowShortDateTime
            // 
            this.ButtonShowShortDateTime.Location = new System.Drawing.Point(303, 125);
            this.ButtonShowShortDateTime.Name = "ButtonShowShortDateTime";
            this.ButtonShowShortDateTime.Size = new System.Drawing.Size(75, 23);
            this.ButtonShowShortDateTime.TabIndex = 10;
            this.ButtonShowShortDateTime.Text = "Show";
            this.ButtonShowShortDateTime.UseVisualStyleBackColor = true;
            this.ButtonShowShortDateTime.Click += new System.EventHandler(this.ButtonShowShortDateTime_Click);
            // 
            // MaskedTextBoxShortDateTime
            // 
            this.MaskedTextBoxShortDateTime.Location = new System.Drawing.Point(133, 127);
            this.MaskedTextBoxShortDateTime.Mask = "00/00/0000 90:00";
            this.MaskedTextBoxShortDateTime.Name = "MaskedTextBoxShortDateTime";
            this.MaskedTextBoxShortDateTime.Size = new System.Drawing.Size(159, 20);
            this.MaskedTextBoxShortDateTime.TabIndex = 9;
            this.MaskedTextBoxShortDateTime.ValidatingType = typeof(System.DateTime);
            // 
            // ButtonShowSSN
            // 
            this.ButtonShowSSN.Location = new System.Drawing.Point(303, 163);
            this.ButtonShowSSN.Name = "ButtonShowSSN";
            this.ButtonShowSSN.Size = new System.Drawing.Size(75, 23);
            this.ButtonShowSSN.TabIndex = 12;
            this.ButtonShowSSN.Text = "Show";
            this.ButtonShowSSN.UseVisualStyleBackColor = true;
            this.ButtonShowSSN.Click += new System.EventHandler(this.ButtonShowSSN_Click);
            // 
            // MaskedTextBoxSSN
            // 
            this.MaskedTextBoxSSN.Location = new System.Drawing.Point(133, 165);
            this.MaskedTextBoxSSN.Mask = "000-00-0000";
            this.MaskedTextBoxSSN.Name = "MaskedTextBoxSSN";
            this.MaskedTextBoxSSN.Size = new System.Drawing.Size(159, 20);
            this.MaskedTextBoxSSN.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "5 Digit Numbers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Short Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Short Date Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Social Security Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 203);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonShowSSN);
            this.Controls.Add(this.MaskedTextBoxSSN);
            this.Controls.Add(this.ButtonShowShortDateTime);
            this.Controls.Add(this.MaskedTextBoxShortDateTime);
            this.Controls.Add(this.ButtonShowShortDate);
            this.Controls.Add(this.MaskedTextBoxShortDate);
            this.Controls.Add(this.ButtonShow5Nums);
            this.Controls.Add(this.MaskedTextBox5Nums);
            this.Controls.Add(this.ButtonShowPhoneNumber);
            this.Controls.Add(this.MaskedTextBoxPhoneNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPhoneNumber;
        private System.Windows.Forms.Button ButtonShowPhoneNumber;
        private System.Windows.Forms.Button ButtonShow5Nums;
        private System.Windows.Forms.MaskedTextBox MaskedTextBox5Nums;
        private System.Windows.Forms.Button ButtonShowShortDate;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxShortDate;
        private System.Windows.Forms.Button ButtonShowShortDateTime;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxShortDateTime;
        private System.Windows.Forms.Button ButtonShowSSN;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxSSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

