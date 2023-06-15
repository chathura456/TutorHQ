using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorHQ.Navigation;
using TutorHQ.Views.Attendence;
using TutorHQ.Views.Class_Fess;
using TutorHQ.Views.Schedules;
using TutorHQ.Views.Student_Data;
using TutorHQ.Views.Tutor_Data;

namespace TutorHQ
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
        
           NavigateTo.To<Add_Student>(this);
        }

        private void btnStdProf_Click(object sender, EventArgs e)
        {
            NavigateTo.To<AllStudentsData>(this);
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            NavigateTo.To<CheckAttendence>(this);
        }

        private void btnClsFees_Click(object sender, EventArgs e)
        {
            NavigateTo.To<ClassFees>(this);
        }

        private void btnTutProf_Click(object sender, EventArgs e)
        {
            NavigateTo.To<AllTutorsData>(this);
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            NavigateTo.To<AllSchedules>(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigateTo.To<LoginForm>(this);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            NavigateTo.To<Dashboard>(this);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
