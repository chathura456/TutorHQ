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
using TutorHQ.Navigation;
using TutorHQ.Views.Attendence;
using TutorHQ.Views.Class_Fess;
using TutorHQ.Views.Schedules;
using TutorHQ.Views.Student_Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TutorHQ.Views.Tutor_Data
{
    public partial class Add_Tutor : Form
    {
        List<Class> classes = new List<Class>();
        public Add_Tutor()
        {
            InitializeComponent();
        }

        private void Add_Tutor_Load(object sender, EventArgs e)
        {
            stream_gropdown.Items.Clear();
            List<Subject> streamList = ClassControllers.GetAllStreams(); // Assuming you have already fetched the list of subjects
            
            Subject defaultSubject = new Subject { Stream = "-- Select Stream --" };
            streamList.Insert(0, defaultSubject);

            stream_gropdown.DataSource = streamList;
            stream_gropdown.DisplayMember = "Stream"; // Replace "SubjectName" with the actual property name in the Subject class to display as the text
            stream_gropdown.ValueMember = "Stream"; // Replace "SubjectID" with the actual property name in the Subject class to use as the value

            stream_gropdown.SelectedIndex = 0;

            // Make the default item read-only and disabled
            stream_gropdown.DropDownStyle = ComboBoxStyle.DropDownList;

            
            subject_dropdown.Enabled = false;

            type_dropdown.Items.Clear();
            type_dropdown.Items.Add(new ListItem("Grade 12", "12"));
            type_dropdown.Items.Add(new ListItem("Grade 13", "13"));
            type_dropdown.Items.Add(new ListItem("Paper Class", "PP"));
            type_dropdown.Items.Add(new ListItem("Revision Class", "RV"));

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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            NavigateTo.To<Dashboard>(this);
        }

        private void stream_gropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStream = stream_gropdown.SelectedValue;
            if (selectedStream != null)
            {
                subject_dropdown.Enabled = true;
                List<Subject> subjectList = ClassControllers.getAllSubjectsByStream(selectedStream.ToString()); // Assuming you have already fetched the list of subjects

                Subject defaultSubject = new Subject { Sub_Name = "-- Select Subject --" };
                subjectList.Insert(0, defaultSubject);

                subject_dropdown.DataSource = subjectList;
                subject_dropdown.DisplayMember = "Sub_Name"; // Replace "SubjectName" with the actual property name in the Subject class to display as the text
                subject_dropdown.ValueMember = "Sub_ID"; // Replace "SubjectID" with the actual property name in the Subject class to use as the value

                subject_dropdown.SelectedIndex = 0;

                // Make the default item read-only and disabled
                subject_dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            }   
        }

        private void add_class_Click(object sender, EventArgs e)
        {
            Class newClass = new Class();
            ListItem selectedListItem = (ListItem)type_dropdown.SelectedItem;
            newClass.Type = selectedListItem.Value;
            newClass.Class_ID = tut_class_id.Text;
            newClass.Fess_Amount = int.Parse(tut_fees.Text);


            classes.Add(newClass);

            if(dataGridView1.DataSource != null)
             { 
            dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }

            dataGridView1.DataSource = classes;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Tutor newTutor = new Tutor();
            newTutor.Tutor_Name = tut_name.Text;
            newTutor.Tutor_Phone = int.Parse(tut_contact.Text.ToString());
            newTutor.Sub_ID = subject_dropdown.SelectedValue.ToString();

            if(classes.Count > 0)
            {
                TutorControllers.AddTutorAndClasses(newTutor, classes);
                clean();
            }
            else
            {
                MessageBox.Show("Please Add Classes to the Tutor");
            }
        }

       public void clean()
        {
            tut_name.Text = "";
            tut_contact.Text = "";
            tut_class_id.Text = "";
            tut_fees.Text = "";
            classes.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}
