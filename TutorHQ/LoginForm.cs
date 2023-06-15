using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorHQ.Controllers;
using TutorHQ.Models;
using TutorHQ.Navigation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TutorHQ
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                txtName.Focus();
                errorProvider1.SetError(txtName, "Username Cannot be null");
            }
            else if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                txtName.Focus();
                errorProvider1.SetError(txtPass, "Password Cannot be null");
            }
            else
            {

                var uname = txtName.Text.ToString().Trim();
                var pass = txtPass.Text.ToString().Trim();

                Users user = LoginControllers.LoginUser(uname, pass);
                CurrentUser.LoginSuccess = user.LoginSuccess;
                CurrentUser.Name = user.Name;
                if (user.LoginSuccess)
                {
                    MessageBox.Show("You're Successfully Login to TuturHQ" , "Login Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    NavigateTo.To<Dashboard>(this);
                }
                else
                {
                    MessageBox.Show("Query Not Execute");
                }


            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                txtPass.Focus();
                errorProvider1.SetError(txtPass, "Password Cannot be null");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
