using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorHQ.Models;

namespace TutorHQ.Controllers
{
    public class StudentControllers : DBconnection
    {
        //---------------------------------- Student Methods ----------------------------------//
        //add student
        public static void AddStudent(Student student)
        {
            if (student == null)
            {
                MessageBox.Show("Student is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SqlConnection conn = GetConnection();
                string sql = "INSERT INTO Student VALUES(@St_Name, @Gender, @NIC, @Phone_NO, @Parent_Name, @Parent_Relation, @Parent_Phone, @Select_Subjects)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@St_Name", student.St_Name);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@NIC", student.NIC);
                cmd.Parameters.AddWithValue("@Phone_NO", student.Phone_NO);
                cmd.Parameters.AddWithValue("@Parent_Name", student.Parent_Name);
                cmd.Parameters.AddWithValue("@Parent_Relation", student.Parent_Relation);
                cmd.Parameters.AddWithValue("@Parent_Phone", student.Parent_Phone);
                cmd.Parameters.AddWithValue("@Select_Subjects", student.Select_Subjects);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Registration Successfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();

            }
        }

        //gwt student details
       /* public static void GetStudentDetails(DataGridView dgv)
        {
            SqlConnection conn = GetConnection();
            string sql = "SELECT * FROM Student";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                }
            }
            conn.Close();
        }
        */
        public static void GetStudentDetails(DataGridView dgv)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "SELECT * FROM Student";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgv.Rows.Add(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetInt32(4),
                                reader.GetString(5),
                                reader.GetString(6),
                                reader.GetInt32(7),
                                reader.GetString(8)
                            );
                        }
                    }
                    reader.Close();
                }
            }
        }

        //get student details by id to Student class
        public static Student GetStudentDetailsByIDSearch(String id)
        {
            Student student = new Student();
            SqlConnection conn = GetConnection();
            string sql = "SELECT * FROM Student WHERE Student_ID = @id;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(id));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    student.Student_ID = Convert.ToInt32(reader["Student_ID"]);

                    student.St_Name = reader["St_Name"].ToString();
                    student.Gender = reader["Gender"].ToString();
                    student.NIC = reader["NIC"].ToString();
                    student.Phone_NO = Convert.ToInt32(reader["Phone_NO"]);
                    student.Parent_Name = reader["Parent_Name"].ToString();
                    student.Parent_Relation = reader["Parent_Relation"].ToString();
                    student.Parent_Phone = reader["Parent_Phone"] != DBNull.Value ? Convert.ToInt32(reader["Parent_Phone"]) : (int?)null;
                    student.Select_Subjects = reader["Select_Subjects"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Student Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
            conn.Close();

            return student;
        }



        //get student details by id to Student class
        public static Student GetStudentDetailsByID(String id)
        {
            Student student = new Student();
            SqlConnection conn = GetConnection();
            string sql = "SELECT * FROM Student WHERE Student_ID = @id;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(id));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                   // student.Student_ID = Convert.ToInt32(reader["St_ID"]);
                    student.St_Name = reader["St_Name"].ToString();
                    student.Gender = reader["Gender"].ToString();
                    student.NIC = reader["NIC"].ToString();
                    student.Phone_NO = Convert.ToInt32(reader["Phone_NO"]);
                    student.Parent_Name = reader["Parent_Name"].ToString();
                    student.Parent_Relation = reader["Parent_Relation"].ToString();
                    student.Parent_Phone = reader["Parent_Phone"] != DBNull.Value ? Convert.ToInt32(reader["Parent_Phone"]) : (int?)null;
                    student.Select_Subjects = reader["Select_Subjects"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Student Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
            conn.Close();

            return student;
        }

        //delete student
        public static void DeleteStudent(int id)
        {
            SqlConnection conn = GetConnection();
            string sql = "DELETE FROM Student WHERE Student_ID = @id;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Deleted Successfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        //update student
        public static void UpdateStudent(Student student)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string sql = "UPDATE Student SET St_Name = @name, Gender = @gender, NIC = @nic, Phone_NO = @phoneNo, Parent_Name = @parentName, Parent_Relation = @parentRelation, Parent_Phone = @parentPhone, Select_Subjects = @selectedSubjects WHERE Student_ID = @studentID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@name", student.St_Name);
                        command.Parameters.AddWithValue("@gender", student.Gender);
                        command.Parameters.AddWithValue("@nic", student.NIC);
                        command.Parameters.AddWithValue("@phoneNo", student.Phone_NO);
                        command.Parameters.AddWithValue("@parentName", student.Parent_Name);
                        command.Parameters.AddWithValue("@parentRelation", student.Parent_Relation);
                        command.Parameters.AddWithValue("@parentPhone", student.Parent_Phone != null ? (object)student.Parent_Phone : DBNull.Value);
                        command.Parameters.AddWithValue("@selectedSubjects", student.Select_Subjects);
                        command.Parameters.AddWithValue("@studentID", student.Student_ID);

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                connection.Close(); // Close the connection
            }
        }
    }
}
