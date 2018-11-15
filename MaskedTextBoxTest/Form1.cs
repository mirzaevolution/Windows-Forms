using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonShowPhoneNumber_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MaskedTextBoxPhoneNumber.Text);
        }

        private void ButtonShow5Nums_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MaskedTextBox5Nums.Text);
        }

        private void ButtonShowShortDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MaskedTextBoxShortDate.Text);
        }

        private void ButtonShowShortDateTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MaskedTextBoxShortDateTime.Text);
        }

        private void ButtonShowSSN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MaskedTextBoxSSN.Text);
        }
    }
}
