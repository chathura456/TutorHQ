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


                string connetionString;
                SqlConnection cnn;
                //connetionString = @"Data Source=DESKTOP-8AQ5791;Initial Catalog=hospital_management;Integrated Security=True";
                connetionString = @"Data Source=tutorhqserver.database.windows.net;Initial Catalog=TutorHQdb;User ID=tutorhq;password=MasterDB@2023;";
                cnn = new SqlConnection(connetionString);
                try
                {
                    /*  cnn.Open();
                      MessageBox.Show("Connection Open  !");
                      string query = "SELECT * FROM Users WHERE Email=@email and Password=@password";
                      SqlCommand cmd = new SqlCommand(query,cnn);
                      cmd.Connection = cnn;
                      cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = "natasha@gmail.com";
                      cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = "1234";
                      cmd.CommandType = CommandType.Text;*/

                    cnn.Open();
                    //MessageBox.Show("Connection Open  !");
                    string query = "SELECT * FROM Users WHERE User_Name=@email and Password=@password";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Connection = cnn;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtName.Text.ToString();
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPass.Text.ToString();
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Login Success");
                            NavigateTo.To<Dashboard>(this);

                        }
                        else
                        {
                            MessageBox.Show("Login Failed ");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ExecuteNonQuery Error! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
