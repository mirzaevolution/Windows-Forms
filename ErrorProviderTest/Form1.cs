using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProviderTest
{
    public partial class FormLogin : Form
    {
        private bool _cancelled = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!_cancelled)
            {
                string emailRegex = @"^([a-zA-Z])([a-zA-Z0-9_\.]+(\w))\@[a-zA-Z0-9_\.]+[a-zA-Z]+$";
                string text = TextBoxEmail.Text.Trim();
                if (!Regex.IsMatch(text, emailRegex))
                {
                    e.Cancel = true;
                    ErrorProviderNotifier.SetError(TextBoxEmail, "Please provide valid email");
                }
                else
                {
                    ErrorProviderNotifier.SetError(TextBoxEmail, "");
                }
            }
            else
            {
                _cancelled = false;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TextBoxEmail.Text) || string.IsNullOrEmpty(TextBoxPassword.Text))
            {
                if (string.IsNullOrEmpty(TextBoxEmail.Text))
                {
                    ErrorProviderNotifier.SetError(TextBoxEmail, "Please fill the email field");
                }
                else
                {
                    ErrorProviderNotifier.SetError(TextBoxEmail, "");
                }

                if (string.IsNullOrEmpty(TextBoxPassword.Text))
                {
                    ErrorProviderNotifier.SetError(TextBoxPassword, "Please fill the password field");
                }
                else
                {
                    ErrorProviderNotifier.SetError(TextBoxPassword, "");
                }
            }
            else
            {
                MessageBox.Show("Access Granted","Welcome");
                ErrorProviderNotifier.Clear();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            TextBoxEmail.Text = "";
            TextBoxPassword.Text = "";
            ErrorProviderNotifier.Clear();
            _cancelled = true;

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cancelled = true;
            e.Cancel = false;
        }
    }
}
