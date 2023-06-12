using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorHQ.Models;

namespace TutorHQ.Controllers
{
    public class DBconnection
    {
        //create sql server connection
        public static SqlConnection GetConnection()
        {
            string sql = @"Data Source=tutorhqserver.database.windows.net;Initial Catalog=TutorHQdb;User ID=tutorhq;password=MasterDB@2023;";


            SqlConnection conn = new SqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show("MySQL Connection! \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

    }
}
