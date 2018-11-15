using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class FormDateTimePickerSample : Form
    {
        public FormDateTimePickerSample()
        {
            InitializeComponent();
        }

        private void ButtonShowOne_Click(object sender, EventArgs e)
        {
            if(DateTimePickerOne.Checked)
            {
                DateTime dateTime = DateTimePickerOne.Value;
                MessageBox.Show(dateTime.ToString());
            }
            else
            {
                MessageBox.Show("Please select any date");
            }
        }

        private void ButtonShowTwo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTimePickerTwo.Value.ToString("dd MMMM yyyy"));
        }

        private void ButtonShowThree_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTimePickerThree.Value;
            MessageBox.Show(dt.ToLongTimeString());
        }

        private void ButtonShowFour_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTimePickerFour.Value;
            MessageBox.Show(dt.ToString("dd MMMM yyyy hh:mm:ss tt"));
        }
    }
}
