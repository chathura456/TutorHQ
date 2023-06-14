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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
