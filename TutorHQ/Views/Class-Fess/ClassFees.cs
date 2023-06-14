using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorHQ.Controllers;
using TutorHQ.Views.Attendence;
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

            Hide();
            AllStudentsData form2 = new AllStudentsData();
            form2.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form2.WindowState = FormWindowState.Maximized;
            }
            form2.Show();
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void ClassFees_Load(object sender, EventArgs e)
        {
            FeesController.GetPaymentDetails(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
