using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewTest1
{
    public partial class Form1 : Form
    {
        private TreeNode CurrentSelectedNode { get; set; }
        private List<TreeNode> CheckedNodes { get; set; } = new List<TreeNode>();
        private void InitializeDefaultTreeViewCollection()
        {
            Random random = new Random();
            TreeNode rootNode = new TreeNode("Root");
            
            TreeNode treeNode1 = new TreeNode($"Node {random.Next(1000,10000)}");
            TreeNode subTreeNode1_2 = new TreeNode($"Node {random.Next(1000, 10000)}");
            subTreeNode1_2.Nodes.Add(new TreeNode($"Node {random.Next(1000, 10000)}"));
            treeNode1.Nodes.AddRange(new TreeNode[]
            {
                new TreeNode($"Node {random.Next(1000,10000)}"),
                subTreeNode1_2
            });

            TreeNode treeNode2 = new TreeNode($"Node {random.Next(1000, 100000)}");
            for(int i = 1; i <= 3; i++)
            {
                treeNode2.Nodes.Add(new TreeNode($"Node {random.Next(1000, 10000)}"));
            }
            rootNode.Nodes.AddRange(new TreeNode[]
            {
                treeNode1,
                treeNode2
            });
            TreeViewRandom.Nodes.Add(rootNode);
            rootNode.Toggle();

        }
        public Form1()
        {
            InitializeComponent();
            InitializeDefaultTreeViewCollection();
            TreeViewRandom.AfterSelect += TreeViewRandom_AfterSelect;
        }

        private void TreeViewRandom_AfterSelect(object sender, TreeViewEventArgs e)
        {

            CurrentSelectedNode = e.Node;
            TextBoxRename.Text = CurrentSelectedNode.Text;
            LabelSelectedTreeNode.Text = CurrentSelectedNode.FullPath;
            
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (CurrentSelectedNode != null)
            {
                if(!string.IsNullOrEmpty(TextBoxAdd.Text))
                {
                    if (TextBoxAdd.Text.ToLower().Trim() == "root")
                    {
                        MessageBox.Show("Name cannot be the same with root node", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CurrentSelectedNode.Nodes.Add(new TreeNode
                        {
                            Text = TextBoxAdd.Text,
                            ToolTipText = TextBoxAdd.Text
                        });
                        TextBoxAdd.Text = string.Empty;
                    }
         
                }
                else
                {
                    MessageBox.Show("Node name cannot be empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select the node you wish to add the sub item to","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ButtonRename_Click(object sender, EventArgs e)
        {
            if (CurrentSelectedNode != null)
            {
                if (!string.IsNullOrEmpty(TextBoxRename.Text))
                {
                    if (TextBoxRename.Text.ToLower().Trim() == "root")
                    {
                        MessageBox.Show("Name cannot be the same with root node","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        CurrentSelectedNode.Text = TextBoxRename.Text;
                        CurrentSelectedNode.ToolTipText = TextBoxRename.Text;
                    }

                }
                else
                {
                    MessageBox.Show("Node name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select the node you wish to rename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TraverseTreeView(TreeNodeCollection nodes, List<TreeNode> checkedNodes)
        {

            if(nodes!=null )
            {
                foreach(TreeNode node in nodes)
                {
                    if (node.Checked) checkedNodes.Add(node);
                    TraverseTreeView(node.Nodes, checkedNodes);
                }
            }
        }
        private void ShowSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CheckedNodes.Count>0)
                CheckedNodes.Clear();
            TraverseTreeView(TreeViewRandom.Nodes, CheckedNodes);
            StringBuilder sb = new StringBuilder();
            foreach(TreeNode node in CheckedNodes)
            {
                sb.AppendLine(node.FullPath);
            }
            MessageBox.Show(sb.ToString(),"Checked Nodes",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void RemoveSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckedNodes.Count > 0)
                CheckedNodes.Clear();
            TraverseTreeView(TreeViewRandom.Nodes, CheckedNodes);
            int total = 0;
            foreach (TreeNode node in CheckedNodes)
            {
                node.Remove();
                total++;
            }
        }

        private void TreeViewRandom_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if(e.Node.Text == "Root")
            {
                e.Cancel = true;
            }
        }
    }
}
