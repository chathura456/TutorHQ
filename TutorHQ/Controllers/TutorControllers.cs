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
    public class TutorControllers : DBconnection
    {
        //---------------------------------- Tutor Methods ----------------------------------//

        //add tutor and classes
        public static void AddTutorAndClasses(Tutor tutor, List<Class> classes)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {

                    // Add the tutor to the Tutor table
                    string tutorSql = "INSERT INTO Tutor (Tutor_Name, Tutor_Phone, Sub_ID) VALUES (@name, @phone, @subID)";

                    using (SqlCommand tutorCommand = new SqlCommand(tutorSql, connection))
                    {
                        tutorCommand.Parameters.AddWithValue("@name", tutor.Tutor_Name);
                        tutorCommand.Parameters.AddWithValue("@phone", tutor.Tutor_Phone);
                        tutorCommand.Parameters.AddWithValue("@subID", tutor.Sub_ID);

                        tutorCommand.ExecuteNonQuery();
                    }

                    // Retrieve the generated Tutor_ID
                    string tutorIdSql = "SELECT SCOPE_IDENTITY()";

                    int tutorID;

                    using (SqlCommand tutorIdCommand = new SqlCommand(tutorIdSql, connection))
                    {
                        tutorID = Convert.ToInt32(tutorIdCommand.ExecuteScalar());
                    }

                    // Add the classes to the Class table
                    foreach (Class classItem in classes)
                    {
                        string classSql = "INSERT INTO Class (Class_ID, Type, Fess_Amount, Tut_ID) VALUES (@classID, @type, @amount, @tutorID)";

                        using (SqlCommand classCommand = new SqlCommand(classSql, connection))
                        {
                            classCommand.Parameters.AddWithValue("@classID", classItem.Class_ID);
                            classCommand.Parameters.AddWithValue("@type", classItem.Type);
                            classCommand.Parameters.AddWithValue("@amount", classItem.Fess_Amount);
                            classCommand.Parameters.AddWithValue("@tutorID", tutorID);

                            classCommand.ExecuteNonQuery();
                        }
                    }
                }

                Console.WriteLine("Tutor and classes added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while adding the tutor and classes: " + ex.Message);
            }
        }


        //update tutor and classes
        public static void UpdateTutorAndClasses(Tutor tutor, List<Class> classes)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {

                    // Update the tutor in the Tutor table
                    string tutorSql = "UPDATE Tutor SET Tutor_Name = @name, Tutor_Phone = @phone, Sub_ID = @subID WHERE Tutor_ID = @id";

                    using (SqlCommand tutorCommand = new SqlCommand(tutorSql, connection))
                    {
                        tutorCommand.Parameters.AddWithValue("@name", tutor.Tutor_Name);
                        tutorCommand.Parameters.AddWithValue("@phone", tutor.Tutor_Phone);
                        tutorCommand.Parameters.AddWithValue("@subID", tutor.Sub_ID);
                        tutorCommand.Parameters.AddWithValue("@id", tutor.Tutor_ID);

                        tutorCommand.ExecuteNonQuery();
                    }

                    // Delete the classes from the Class table
                    string deleteSql = "DELETE FROM Class WHERE Tut_ID = @id";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteSql, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@id", tutor.Tutor_ID);

                        deleteCommand.ExecuteNonQuery();
                    }

                    // Add the classes to the Class table
                    foreach (Class classItem in classes)
                    {
                        string classSql = "INSERT INTO Class (Class_ID, Type, Fess_Amount, Tut_ID) VALUES (@classID, @type, @amount, @tutorID)";

                        using (SqlCommand classCommand = new SqlCommand(classSql, connection))
                        {
                            classCommand.Parameters.AddWithValue("@classID", classItem.Class_ID);
                            classCommand.Parameters.AddWithValue("@type", classItem.Type);
                            classCommand.Parameters.AddWithValue("@amount", classItem.Fess_Amount);
                            classCommand.Parameters.AddWithValue("@tutorID", tutor.Tutor_ID);

                            classCommand.ExecuteNonQuery();
                        }
                    }
                }

                Console.WriteLine("Tutor and classes updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating the tutor and classes: " + ex.Message);
            }
        }
        

        //delete tutor and classes
        public static void DeleteTutorAndClasses(int id)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    // Delete the classes from the Class table
                    string deleteSql = "DELETE FROM Class WHERE Tut_ID = @id";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteSql, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@id", id);

                        deleteCommand.ExecuteNonQuery();
                    }

                    // Delete the tutor from the Tutor table
                    string tutorSql = "DELETE FROM Tutor WHERE Tutor_ID = @id";

                    using (SqlCommand tutorCommand = new SqlCommand(tutorSql, connection))
                    {
                        tutorCommand.Parameters.AddWithValue("@id", id);

                        tutorCommand.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Tutor and classes deleted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deleting the tutor and classes: " + ex.Message);
            }
        }
        

        //get all tutors
        public static List<Tutor> GetAllTutors()
        {
            List<Tutor> tutors = new List<Tutor>();

            try
            {
                using (SqlConnection connection = GetConnection())
                {

                    string sql = "SELECT * FROM Tutor";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Tutor tutor = new Tutor();

                                tutor.Tutor_ID = Convert.ToInt32(reader["Tutor_ID"]);
                                tutor.Tutor_Name = Convert.ToString(reader["Tutor_Name"]);
                                tutor.Tutor_Phone = Convert.ToInt32(reader["Tutor_Phone"]);
                                tutor.Sub_ID = Convert.ToString(reader["Sub_ID"]);

                                tutors.Add(tutor);
                            }
                        }
                    }
                }

                Console.WriteLine("Tutors retrieved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving the tutors: " + ex.Message);
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tutors;
        }

        //get tutor by id
        public static Tutor GetTutorById(int id)
        {
            Tutor tutor = new Tutor();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string sql = "SELECT * FROM Tutor WHERE Tutor_ID = @id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tutor.Tutor_ID = Convert.ToInt32(reader["Tutor_ID"]);
                                tutor.Tutor_Name = Convert.ToString(reader["Tutor_Name"]);
                                tutor.Tutor_Phone = Convert.ToInt32(reader["Tutor_Phone"]);
                                tutor.Sub_ID = Convert.ToString(reader["Sub_ID"]);
                            }
                        }
                    }
                }

                Console.WriteLine("Tutor retrieved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving the tutor: " + ex.Message);
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tutor;
        }

        public static Subject GetSubjectByID(string id)
        { 
           Subject subject = new Subject();

            try
            {
                using (SqlConnection connection = GetConnection())
                {

                    string sql = "SELECT * FROM Subject WHERE Sub_ID = @id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                subject.Sub_ID = reader["Sub_ID"].ToString();
                                subject.Sub_Name = reader["Sub_Name"].ToString();
                                subject.Stream = reader["Stream"].ToString();
                            }
                        }
                    }
                }

                Console.WriteLine("Subject retrieved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving the subject: " + ex.Message);
            }

            return subject;
        }

        //show all subjects
        public static List<Subject> GetAllSubjects()
        {
            List<Subject> subjectList = new List<Subject>();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string sql = "SELECT Sub_ID, Sub_Name, Stream FROM Subject";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Subject subject = new Subject
                                {
                                    Sub_ID = reader["Sub_ID"].ToString(),
                                    Sub_Name = reader["Sub_Name"].ToString(),
                                    Stream = reader["Stream"].ToString()
                                };

                                subjectList.Add(subject);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving subjects: " + ex.Message);
            }

            return subjectList;
        }

    }
}
