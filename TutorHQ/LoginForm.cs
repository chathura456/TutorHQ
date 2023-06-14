using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorHQ.Controllers;
using TutorHQ.Models;
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
            if (txtName.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Email and Password Fields are empty ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            Hide();
                            Dashboard dashboard = new Dashboard();
                            dashboard.Closed += (s, args) => this.Close();
                            if (this.WindowState == FormWindowState.Maximized)
                            {
                                dashboard.WindowState = FormWindowState.Maximized;
                            }
                            dashboard.Show();

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
    }
}
