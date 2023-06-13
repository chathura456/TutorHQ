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
    public class LoginControllers : DBconnection
    {
     
        //---------------------------------- Login Methods ----------------------------------//

        //check if user exists and get data
        public static Users LoginUser(string username, string password)
        {
            Users user = new Users();

            using (SqlConnection connection = GetConnection())
            {
                string sql = "select * from Users where User_Name = @username and Password = @password";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            user.LoginSuccess = true;
                            user.UserID = reader.GetInt32(reader.GetOrdinal("User_ID"));
                            user.Name = reader.GetString(reader.GetOrdinal("User_Name"));
                            reader.Close();
                            string sql1 = "EXEC LoginUser @username = @u1, @password = @p1";
                            SqlCommand cmd1 = new SqlCommand(sql1, connection);
                            cmd1.Parameters.AddWithValue("@u1", username);
                            cmd1.Parameters.AddWithValue("@p1", password);
                            try
                            {
                                cmd1.ExecuteNonQuery();

                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password");
                        }
                    }
                }
             
            }

            return user;
        }

        //user logout
        public static void LogoutUser()
        {
            // Clear the stored user data
            CurrentUser.LoginSuccess = false;
            CurrentUser.UserID = 0;
            CurrentUser.SessionID = string.Empty;
            CurrentUser.Name = string.Empty;
        }
    }
}
