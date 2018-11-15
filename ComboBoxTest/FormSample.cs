using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxTest
{
    
    public partial class FormSample : Form
    {
        public List<Employee> Employees { get; set; }
        public FormSample()
        {
            InitializeComponent();

            Employees = new List<Employee>
            {
                new Employee
                {
                    FullName = "Mirza Ghulam Rasyid"
                },
                new Employee
                {
                    FullName = "Michael Hawk"
                },
                new Employee
                {
                    FullName = "Rara Anjani"
                }
            };
        }


        private void FormSample_Load(object sender, EventArgs e)
        {
            ComboBoxEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEmployee.ValueMember = "ID";
            ComboBoxEmployee.DisplayMember = "FullName";
            ComboBoxEmployee.DataSource = Employees;

        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ComboBoxEmployee.SelectedValue?.ToString();
                string name = ComboBoxEmployee.Text?.ToString();
                MessageBox.Show($"Selected Value: {id}\nSelected Name: {name}");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error");
            }
        }
    }
}
