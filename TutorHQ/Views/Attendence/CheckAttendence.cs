using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorHQ.Views.Student_Data;

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
    }
}
