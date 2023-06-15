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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TutorHQ.Views.Student_Data
{
    public partial class AllStudentsData : Form
    {
        public AllStudentsData()
        {
            InitializeComponent();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            Hide();
            Student_Proile form2 = new Student_Proile();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AllStudentsData_Load(object sender, EventArgs e)
        {
            StudentControllers.GetStudentDetails(dataGridView1);

            // Load the initial student data
            RefreshData();
        }


        private void RefreshData()
        {
            // Clear the existing data in the DataGridView
            dataGridView1.Rows.Clear();


            // Clear the text in the TextBox
            textBox1.Clear();

            // Reload the student data
            StudentControllers.GetStudentDetails(dataGridView1);
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                Hide();
                Student_Proile dashboard = new Student_Proile();
                dashboard.id = id;
                dashboard.Closed += (s, args) => this.Close();
                if (this.WindowState == FormWindowState.Maximized)
                {
                    dashboard.WindowState = FormWindowState.Maximized;
                }
                dashboard.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            Add_Student form = new Add_Student();
            form.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string studentID = textBox1.Text;
           // Student student = StudentControllers.GetStudentDetailsByIDSearch(studentID);
               
            /*
            dataGridView1.Rows.Clear();
            if (student != null)
            {
                dataGridView1.Rows.Add(student.Student_ID, student.St_Name, student.Gender, student.NIC, student.Phone_NO, student.Parent_Name, student.Parent_Relation, student.Parent_Phone, student.Select_Subjects);
            }
            else
            {
                MessageBox.Show("Student Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Call the RefreshData method to reload the student data
            RefreshData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Call the RefreshData method to reload the student data
            RefreshData();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
