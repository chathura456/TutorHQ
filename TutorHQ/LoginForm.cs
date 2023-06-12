using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TutorHQ
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard dashboard= new Dashboard();
            dashboard.Closed += (s, args) => this.Close();
            if(this.WindowState== FormWindowState.Maximized )
            {
                dashboard.WindowState= FormWindowState.Maximized;
            }
            dashboard.Show();
        }
    }
}
