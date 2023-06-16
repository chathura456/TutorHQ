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

namespace TutorHQ.Views.Tutor_Data
{
    public partial class Tutor_Profile : Form
    {
        public Tutor tutor;
        public Tutor_Profile()
        {
            InitializeComponent();
        }

        private void Tutor_Profile_Load(object sender, EventArgs e)
        {
            if (tutor != null) 
            { 
                lblName.Text = tutor.Tutor_Name;
                lblPhone.Text = tutor.Tutor_Phone.ToString();

                Subject subject = TutorControllers.GetSubjectByID(tutor.Sub_ID);
                if (subject != null) { 
                  lblSubject.Text = subject.Sub_Name;
                    label18.Text = subject.Stream;

                }

                List<Class> classList = ClassControllers.getGlassByTutorID(tutor.Tutor_ID);
                dataGridView1.DataSource = classList;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigateTo.To<Dashboard>(this);
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            NavigateTo.To<AllTutorsData>(this);
        }
    }
}
