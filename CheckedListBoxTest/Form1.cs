using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBoxTest
{
    public partial class Form1 : Form
    {
        delegate void SingleParamMethodInvoker<T>(T value);
        private void AddData()
        {
            Action<int> addItems = (x) =>
            {

                CheckedListBoxMain.Items.Add(new Employee
                {
                    FullName = $"Employee {x}"
                });
            };
            SingleParamMethodInvoker<int> invoker = new SingleParamMethodInvoker<int>(addItems);
            for (int i = 0; i < 11; i++)
            {
                if (CheckedListBoxMain.InvokeRequired)
                {
                    CheckedListBoxMain.Invoke(invoker, i);
                }
                else
                {
                    addItems(i);
                }
                
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() => AddData());
        }

        private void ButtonSwitchToLeft_Click(object sender, EventArgs e)
        {
            for(int i=0;i<CheckedListBoxMain.CheckedItems.Count; i++)
            {
                var item = CheckedListBoxMain.CheckedItems[i];
                ListBoxMain.Items.Add(item);
                CheckedListBoxMain.Items.Remove(item);
                i--;

            }
        }

        private void ButtonSwitchToRight_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListBoxMain.SelectedItems.Count; i++)
            {
                var item = ListBoxMain.SelectedItems[i];
                CheckedListBoxMain.Items.Add(item);
                ListBoxMain.Items.Remove(item);
                i--;

            }
        }
    }
}
