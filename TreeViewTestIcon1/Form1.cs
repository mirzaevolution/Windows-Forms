using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewTestIcon1
{
    public partial class Form1 : Form
    {
        private delegate void AddData(TreeNode node, TreeNode subNode);
        public Form1()
        {
            InitializeComponent();
            try
            {

                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    ComboBoxDrives.Items.Add(new DriveDetail
                    {
                        Letter = drive.Name,
                        Name = drive.VolumeLabel
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void AddDataToTreeNode(TreeNode node, TreeNode subNode)
        {
            node.Nodes.Add(subNode);
        }
        private void RecurseDrive(DirectoryInfo root, TreeNode node)
        {
            try
            {
                foreach(DirectoryInfo dirInfo in root.GetDirectories())
                {
                    try
                    {

                        TreeNode subNode = new TreeNode(dirInfo.Name)
                        {
                            ImageIndex = 1,
                            SelectedImageIndex = 2
                        };
                        if (TreeViewFolder.InvokeRequired)
                        {
                            AddData invoker = new AddData(AddDataToTreeNode);
                            TreeViewFolder.Invoke(invoker, node, subNode);
                        }
                        else
                        {
                            node.Nodes.Add(subNode);
                        }
                        RecurseDrive(dirInfo, subNode);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ComboBoxDrives.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void ButtonScan_Click(object sender, EventArgs e)
        {
            try
            {
                DriveDetail detail = ComboBoxDrives.SelectedItem as DriveDetail;
                TreeNode root = new TreeNode(detail.Letter);
                root.ImageIndex = root.SelectedImageIndex = 0;
                TreeViewFolder.Nodes.Add(root);
                //RecurseDrive(new DirectoryInfo("D:\\"), root);
                Task.Run(() => RecurseDrive(new DirectoryInfo(detail.Letter), root));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void TreeViewFolder_AfterExpand(object sender, TreeViewEventArgs e)
        {

        }

        private void TreeViewFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
