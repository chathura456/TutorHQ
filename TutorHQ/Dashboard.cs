using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Hide();
            Add_Student form= new Add_Student();
            form.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            form.Show();
        }

        private void btnStdProf_Click(object sender, EventArgs e)
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

        private void btnAttend_Click(object sender, EventArgs e)
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

        private void btnClsFees_Click(object sender, EventArgs e)
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

        private void btnTutProf_Click(object sender, EventArgs e)
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

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            Hide();
            Schedules form6 = new Schedules();
            form6.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form6.WindowState = FormWindowState.Maximized;
            }
            form6.Show();
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
    }
}
