using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarSample
{
    public partial class FormCalendarSample : Form
    {
        public FormCalendarSample()
        {
            InitializeComponent();
        }

        private void ButtonShowSelected_Click(object sender, EventArgs e)
        {
            for (DateTime dt = MonthCalendarMain.SelectionRange.Start; dt<=MonthCalendarMain.SelectionRange.End; dt = dt.AddDays(1))
            {
                ListBoxSelectedDates.Items.Add(dt.ToString("dd MMM yyyy"));
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ListBoxSelectedDates.Items.Clear();
        }
    }
}
