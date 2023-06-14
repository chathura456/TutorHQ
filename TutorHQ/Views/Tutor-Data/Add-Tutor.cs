using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTutorName_Click(object sender, EventArgs e)
        {

        }

        private void txtTutorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Tutor_Load(object sender, EventArgs e)
        {

        }

        private void lblSubName3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
