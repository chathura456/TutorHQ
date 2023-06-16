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
            dataGridView1.DataSource = tutors;
            //profile view column
            DataGridViewButtonColumn profileColumn = new DataGridViewButtonColumn();
            profileColumn.HeaderText = "View Profile";
            profileColumn.Text = "View";
            profileColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(profileColumn);

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

        private void label1_Click_1(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Tutor tutor = new Tutor();
                tutor.Tutor_ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                tutor.Tutor_Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tutor.Tutor_Phone = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                tutor.Sub_ID = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                Hide();
                Tutor_Profile dashboard = new Tutor_Profile();
                dashboard.tutor = tutor;
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
            NavigateTo.To<Add_Tutor>(this);
        }
    }
}
