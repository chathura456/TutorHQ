using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                connection.Open();

                using (SqlCommand command = new SqlCommand("LoginUser", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            user.LoginSuccess = true;
                            user.UserID = reader.GetInt32(reader.GetOrdinal("User_ID"));
                            user.SessionID = reader.GetString(reader.GetOrdinal("Session_ID"));
                            user.Name = reader.GetString(reader.GetOrdinal("User_Name"));
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
