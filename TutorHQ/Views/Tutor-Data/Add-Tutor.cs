using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TutorHQ.Views.Tutor_Data
{
    public partial class Add_Tutor : Form
    {
        public object TutorControllers { get; private set; }

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

        private void txtClassFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTutorName.Text == null)
            {
                object value = errorProvider1.SetError(txtTutorName, "Tutor Name is Required");
            }

            string name = txtTutorName.Text;
            int CNo = int.Parse(txtTutorPhNo.Text);
            string SubName = cmbSubName.SelectedItem.ToString();
            string ClassId = txtClassId.Text;
            string ClassTyp = cmbClassTyp.SelectedItem.ToString();
            string ClassFees = txtClassFees.Text;

            Tutor newTutor = new Tutor();
            newTutor.Tt_Name = name;
            newTutor.Tt_CNo = CNo;
            newTutor.Tt_SubName = SubName;
            newTutor.Tt_ClassId = ClassId;
            newTutor.Tt_ClassTyp = ClassTyp;
            newTutor.Tt_ClassFees = ClassFees;

            
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txtTutorName.Clear();   
            txtTutorPhNo.Clear();
            cmbSubName.ResetText();
            txtClassId.Clear();
            cmbClassTyp.ResetText();

        }

    }
}
