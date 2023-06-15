using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorHQ.Models;
using TutorHQ.Controllers;

namespace TutorHQ.Views.Student_Data
{
    public partial class Add_Student : Form

    {
       
        public Add_Student()
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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void button10_Click(object sender, EventArgs e)
        {

            // Assuming you have a button control named 'registerButton' and relevant UI controls for each student property

            // Event handler for the registerButton's click event
            if (textBox1.Text == null)
            {
                errorProvider.SetError(textBox1, "First Name is Required");
            }
            
                // Retrieve the data entered by the user from the UI controls
                string name = textBox1.Text;
                string gender = comboBox2.SelectedItem.ToString();
                string nic = textBox2.Text;
                int phoneNo = int.Parse(textBox3.Text);
                //string address = textBox4.Text;
            //string parentaddress = textBox9.Text;
            string parentName = textBox5.Text;
                string parentRelation = textBox6.Text;
                int parentPhone = int.Parse(textBox7.Text);
                string selectedSubjects = textBox9.Text;

                // Create a new Student object and set its properties
                Student newStudent = new Student();
                newStudent.St_Name = name;
                newStudent.Gender = gender;
                newStudent.NIC = nic;
                newStudent.Phone_NO = phoneNo;
                newStudent.Parent_Name = parentName;
                newStudent.Parent_Relation = parentRelation;
                newStudent.Parent_Phone = parentPhone;
                newStudent.Select_Subjects = selectedSubjects;


            // Call the AddStudent method to register the student
            StudentControllers.AddStudent(newStudent);
            Clear();
           
            }

        private void button9_Click(object sender, EventArgs e)
        {
            Clear(); 
        }

        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox9.Clear();
            comboBox2.ResetText();
            

        }
    }
    }

