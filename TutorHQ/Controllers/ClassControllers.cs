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

        //get class details by tutor id
        public static List<Class> getGlassByTutorID(int id)
        {
            List<Class> classList = new List<Class>();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    string sql = "select * from Class where Tut_ID = @id";

                    using (SqlCommand tutorCommand = new SqlCommand(sql, connection))
                    {
                        tutorCommand.Parameters.AddWithValue("@id", id);

                        //tutorCommand.ExecuteNonQuery();
                        using (SqlDataReader reader = tutorCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Class class1 = new Class
                                {
                                    Class_ID = reader["Class_ID"].ToString(),
                                    Type = reader["Type"].ToString(),
                                    Fess_Amount = int.Parse(reader["Fess_Amount"].ToString())
                                };

                                classList.Add(class1);
                            }
                        }
                    }

                }

            }catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving class details: " + ex.Message);
            }
            return classList;
        }

        //get all streams
        public static List<Subject> GetAllStreams()
        {
            List<Subject> streamList = new List<Subject>();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    string sql = "SELECT DISTINCT Stream FROM Subject";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Subject subject = new Subject
                                {
                                    Stream = reader["Stream"].ToString()
                                };

                                streamList.Add(subject);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving stream details: " + ex.Message);
            }

            return streamList;
        }

        //get all subjects by stream
        public static List<Subject> getAllSubjectsByStream(string stream)
        {
            List<Subject> streamList = new List<Subject>();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    string sql = "SELECT * FROM Subject where Stream = @stream";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@stream", stream);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Subject subject = new Subject
                                {
                                    Sub_Name = reader["Sub_Name"].ToString(),
                                    Sub_ID = reader["Sub_ID"].ToString(),
                                };

                                streamList.Add(subject);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving stream details: " + ex.Message);
            }

            return streamList;
        }
       

    }
}
