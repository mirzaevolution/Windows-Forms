namespace TreeViewTest1
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
            this.TreeViewRandom = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxAdd = new System.Windows.Forms.TextBox();
            this.TextBoxRename = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonRename = new System.Windows.Forms.Button();
            this.LabelSelectedTreeNode = new System.Windows.Forms.Label();
            this.ContextMenuStripTreeViewRandom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripTreeViewRandom.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeViewRandom
            // 
            this.TreeViewRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeViewRandom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeViewRandom.CheckBoxes = true;
            this.TreeViewRandom.ContextMenuStrip = this.ContextMenuStripTreeViewRandom;
            this.TreeViewRandom.Location = new System.Drawing.Point(12, 148);
            this.TreeViewRandom.Name = "TreeViewRandom";
            this.TreeViewRandom.Size = new System.Drawing.Size(369, 292);
            this.TreeViewRandom.TabIndex = 6;
            this.TreeViewRandom.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewRandom_BeforeCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rename:";
            // 
            // TextBoxAdd
            // 
            this.TextBoxAdd.Location = new System.Drawing.Point(83, 26);
            this.TextBoxAdd.Name = "TextBoxAdd";
            this.TextBoxAdd.Size = new System.Drawing.Size(201, 22);
            this.TextBoxAdd.TabIndex = 1;
            // 
            // TextBoxRename
            // 
            this.TextBoxRename.Location = new System.Drawing.Point(83, 59);
            this.TextBoxRename.Name = "TextBoxRename";
            this.TextBoxRename.Size = new System.Drawing.Size(201, 22);
            this.TextBoxRename.TabIndex = 4;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(293, 26);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 25);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonRename
            // 
            this.ButtonRename.Location = new System.Drawing.Point(293, 58);
            this.ButtonRename.Name = "ButtonRename";
            this.ButtonRename.Size = new System.Drawing.Size(75, 25);
            this.ButtonRename.TabIndex = 5;
            this.ButtonRename.Text = "Rename";
            this.ButtonRename.UseVisualStyleBackColor = true;
            this.ButtonRename.Click += new System.EventHandler(this.ButtonRename_Click);
            // 
            // LabelSelectedTreeNode
            // 
            this.LabelSelectedTreeNode.AutoEllipsis = true;
            this.LabelSelectedTreeNode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelSelectedTreeNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSelectedTreeNode.Location = new System.Drawing.Point(12, 106);
            this.LabelSelectedTreeNode.Name = "LabelSelectedTreeNode";
            this.LabelSelectedTreeNode.Size = new System.Drawing.Size(369, 23);
            this.LabelSelectedTreeNode.TabIndex = 7;
            this.LabelSelectedTreeNode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContextMenuStripTreeViewRandom
            // 
            this.ContextMenuStripTreeViewRandom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStripTreeViewRandom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowSelectedToolStripMenuItem,
            this.RemoveSelectedToolStripMenuItem});
            this.ContextMenuStripTreeViewRandom.Name = "ContextMenuStripTreeViewRandom";
            this.ContextMenuStripTreeViewRandom.Size = new System.Drawing.Size(194, 52);
            // 
            // ShowSelectedToolStripMenuItem
            // 
            this.ShowSelectedToolStripMenuItem.Name = "ShowSelectedToolStripMenuItem";
            this.ShowSelectedToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.ShowSelectedToolStripMenuItem.Text = "Show Selected";
            this.ShowSelectedToolStripMenuItem.Click += new System.EventHandler(this.ShowSelectedToolStripMenuItem_Click);
            // 
            // RemoveSelectedToolStripMenuItem
            // 
            this.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem";
            this.RemoveSelectedToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.RemoveSelectedToolStripMenuItem.Text = "Remove Selected";
            this.RemoveSelectedToolStripMenuItem.Click += new System.EventHandler(this.RemoveSelectedToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 452);
            this.Controls.Add(this.LabelSelectedTreeNode);
            this.Controls.Add(this.ButtonRename);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxRename);
            this.Controls.Add(this.TextBoxAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TreeViewRandom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeView Sample";
            this.ContextMenuStripTreeViewRandom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxAdd;
        private System.Windows.Forms.TextBox TextBoxRename;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonRename;
        private System.Windows.Forms.Label LabelSelectedTreeNode;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripTreeViewRandom;
        private System.Windows.Forms.ToolStripMenuItem ShowSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveSelectedToolStripMenuItem;
    }
}

