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

namespace TutorHQ.Views.Tutor_Data
{
    public partial class AllTutorsData : Form
    {
        public AllTutorsData()
        {
            InitializeComponent();
        }

        private void AllTutorsData_Load(object sender, EventArgs e)
        {
            List<Tutor> tutors = TutorControllers.GetAllTutors();

            dataGridView1.Columns.Clear(); // Clear existing columns if any
            
            //profile view column
            DataGridViewButtonColumn profileColumn = new DataGridViewButtonColumn();
            profileColumn.HeaderText = "View Profile";
            profileColumn.Text = "View";
            profileColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add("Tutor_ID", "Tutor ID");
            dataGridView1.Columns.Add("Tutor_Name", "Tutor Name");
            dataGridView1.Columns.Add("Tutor_Phone", "Tutor Phone");
            dataGridView1.Columns.Add("Sub_ID", "Subject ID");
            dataGridView1.Columns.Add(profileColumn);

            dataGridView1.DataSource = tutors;
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

        private void addTutor_Click(object sender, EventArgs e)
        {
            Hide();
            Add_Tutor form = new Add_Tutor();
            form.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            form.Show();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            Hide();
            Tutor_Profile form1 = new Tutor_Profile();
            form1.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form1.WindowState = FormWindowState.Maximized;
            }
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
