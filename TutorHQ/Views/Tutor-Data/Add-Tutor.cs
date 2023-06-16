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

namespace TutorHQ.Views.Tutor_Data
{
    public partial class Add_Tutor : Form
    {
        public Add_Tutor()
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
    }
}
