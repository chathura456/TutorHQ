using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorHQ.Models;

namespace TutorHQ.Controllers
{
    public class ClassControllers : DBconnection
    {
        //get all classes details
        public static List<ClassDetails> GetAllClassDetails()
        {
            List<ClassDetails> classList = new List<ClassDetails>();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string sql = "SELECT c.Class_ID, t.Tutor_Name, s.Sub_Name, c.Type FROM Class c INNER JOIN Tutor t ON c.Tut_ID = t.Tutor_ID INNER JOIN Subject s ON c.Sub_ID = s.Sub_ID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClassDetails classDetails = new ClassDetails
                                {
                                    Class_ID = reader["Class_ID"].ToString(),
                                    Tutor_Name = reader["Tutor_Name"].ToString(),
                                    Subject_Name = reader["Sub_Name"].ToString(),
                                    Type = reader["Type"].ToString()
                                };

                                classList.Add(classDetails);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving class details: " + ex.Message);
            }

            return classList;
        }

    }
}
