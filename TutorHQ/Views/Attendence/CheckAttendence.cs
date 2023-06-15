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
using TutorHQ.Models;
using TutorHQ.Views.Class_Fess;
using TutorHQ.Views.Tutor_Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TutorHQ.Views.Attendence
{
    public partial class CheckAttendence : Form


    {

        public CheckAttendence()
        {
            InitializeComponent();
        }

        private void addAtten_Click(object sender, EventArgs e)
        {
            Hide();
            AddAttendence form2 = new AddAttendence();
            form2.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form2.WindowState = FormWindowState.Maximized;
            }
            form2.Show();
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

        /* private void button1_Click(object sender, EventArgs e)
         {
             string studentID = textBox1.Text;
             string classID = textBox2.Text;
             string month = comboBox1.Text;



             AttendanceDetails attendence = AttendenceControllers.GetAttendanceDetailsByStudent(studentID, classID, month);


             dataGridView1.Rows.Clear();
             if (attendence != null)
             {
                 dataGridView1.Rows.Add(attendence.StudentID, attendence.Status, attendence.Time);
             }
             else
             {
                 MessageBox.Show("Student Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }


         */
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int studentID))
            {
                string classID = textBox1.Text;
                string month = comboBox1.Text;

                List<AttendanceDetails> attendanceList = AttendenceControllers.GetAttendanceDetailsByStudent(studentID, month, classID);

                dataGridView1.Rows.Clear();

                if (attendanceList.Count > 0)
                {
                    foreach (AttendanceDetails attendance in attendanceList)
                    {
                        dataGridView1.Rows.Add(attendance.StudentID);
                    }
                }
                else
                {
                    MessageBox.Show("Student Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Student ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void CheckAttendence_Load(object sender, EventArgs e)
        {
            AttendenceControllers.GetAttendanceDetails(dataGridView1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
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

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AttendenceControllers.GetAttendanceDetails(dataGridView1);
        }
    }
} 
