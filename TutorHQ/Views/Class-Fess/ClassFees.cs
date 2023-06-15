using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorHQ.Controllers;
using TutorHQ.Navigation;
using TutorHQ.Views.Attendence;
using TutorHQ.Views.Schedules;
using TutorHQ.Views.Student_Data;
using TutorHQ.Views.Tutor_Data;

namespace TutorHQ.Views.Class_Fess
{
    public partial class ClassFees : Form
    {
        public ClassFees()
        {
            InitializeComponent();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                dashboard.WindowState = FormWindowState.Maximized;
            }
            dashboard.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Hide();
            CheckAttendence form3 = new CheckAttendence();
            form3.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form3.WindowState = FormWindowState.Maximized;
            }
            form3.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

            Hide();
            AllTutorsData form5 = new AllTutorsData();
            form5.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form5.WindowState = FormWindowState.Maximized;
            }
            form5.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Hide();
            ClassFees form4 = new ClassFees();
            form4.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form4.WindowState = FormWindowState.Maximized;
            }
            form4.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

           /* Hide();
            AllStudentsData form2 = new AllStudentsData();
            form2.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form2.WindowState = FormWindowState.Maximized;
            }
            form2.Show();*/
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            Hide();
            LoginForm form7 = new LoginForm();
            form7.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form7.WindowState = FormWindowState.Maximized;
            }
            form7.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                dashboard.WindowState = FormWindowState.Maximized;
            }
            dashboard.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using(DataTable dt = new DataTable("Student"))
                    {
                        using(SqlCommand cmd = new SqlCommand("select * from Fees where St_ID=@St_ID",cn))
                        {
                            //cmd.Parameters.AddWithValue("Month1", Month1.ValueType);
                            cmd.Parameters.AddWithValue("St_ID", textBox1.Text);
                            //cmd.Parameters.AddWithValue("Month1", string.Format("%{0}%", textBox1.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            lblTotal.Text = $"Total records: {dataGridView1.RowCount}";

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void ClassFees_Load_1(object sender, EventArgs e)
        {
            FeesController.GetPaymentDetails(dataGridView1);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the Enter key character from being entered in the TextBox
                string enteredText = textBox1.Text;

                // Add the entered text to a new row in the DataGridView
                dataGridView1.Rows.Add(enteredText);

                // Clear the TextBox after adding the data
                textBox1.Clear();
            }
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FeesController.GetPaymentDetails(dataGridView1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NavigateTo.To<CheckAttendence>(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigateTo.To<ClassFees>(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigateTo.To<AllSchedules>(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NavigateTo.To<AllStudentsData>(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NavigateTo.To<AllTutorsData>(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NavigateTo.To<LoginForm>(this);
        }
    }
    }

