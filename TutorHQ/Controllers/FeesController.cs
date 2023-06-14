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
    public class FeesController : DBconnection
    {
        //get all fees details by month for a class
        public static List<StudentPaymentDetails> GetPaymentDetailsByMonth(string month)
        {
            List<StudentPaymentDetails> paymentList = new List<StudentPaymentDetails>();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string sql = @"SELECT s.Student_ID, s.St_Name, c.Class_ID, CONCAT(t.Tutor_Name, ' - ', su.Sub_Name, ' (', c.Type, ')') AS ClassName, c.Fess_Amount
                            FROM Class c
                            INNER JOIN Tutor t ON c.Tut_ID = t.Tutor_ID
                            INNER JOIN Subject su ON c.Sub_ID = su.Sub_ID
                            LEFT JOIN Fees p ON p.Class_ID = c.Class_ID AND p.Month1 = @month
                            INNER JOIN Student s ON s.Student_ID = p.St_ID
                            WHERE p.Payment_ID IS NULL OR p.Payment_ID > 0";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@month", month);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StudentPaymentDetails paymentDetails = new StudentPaymentDetails
                                {
                                    Student_ID = Convert.ToInt32(reader["Student_ID"]),
                                    Student_Name = reader["St_Name"].ToString(),
                                    Class_ID = reader["Class_ID"].ToString(),
                                    ClassName = reader["ClassName"].ToString(),
                                    Month = month,
                                    Payment_Date = null,
                                    Fee_Amount = Convert.ToInt32(reader["Fess_Amount"])
                                };

                                paymentList.Add(paymentDetails);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving payment details: " + ex.Message);
            }

            return paymentList;
        }





        //get all fees details by student
        public static List<StudentPaymentDetails> GetPaymentDetailsByStudentID(int studentID)
        {
            List<StudentPaymentDetails> paymentList = new List<StudentPaymentDetails>();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string sql = @"SELECT p.Payment_ID, s.St_Name, c.Class_ID, CONCAT(t.Tutor_Name, ' - ', su.Sub_Name, ' (', c.Type, ')') AS ClassName, p.Month1, p.Payment_date, c.Fess_Amount
                            FROM Fees p
                            INNER JOIN Student s ON p.St_ID = s.Student_ID
                            INNER JOIN Class c ON p.Class_ID = c.Class_ID
                            INNER JOIN Tutor t ON c.Tut_ID = t.Tutor_ID
                            INNER JOIN Subject su ON c.Sub_ID = su.Sub_ID
                            WHERE s.Student_ID = @studentID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StudentPaymentDetails paymentDetails = new StudentPaymentDetails
                                {
                                    Student_Name = reader["St_Name"].ToString(),
                                    Class_ID = reader["Class_ID"].ToString(),
                                    ClassName = reader["ClassName"].ToString(),
                                    Month = reader["Month1"].ToString(),
                                    Payment_Date = reader["Payment_date"].ToString(),
                                    Fee_Amount = Convert.ToInt32(reader["Fess_Amount"])
                                };

                                paymentList.Add(paymentDetails);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving payment details: " + ex.Message);
            }

            return paymentList;
        }




        public static void GetPaymentDetails(DataGridView dgv)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "SELECT * FROM Fees";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string column1 = reader.IsDBNull(0) ? string.Empty : reader.GetInt32(0).ToString();
                                string column2 = reader.IsDBNull(1) ? string.Empty : reader.GetInt32(1).ToString();
                                string column3 = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                                string column4 = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                                string column5 = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);

                                dgv.Rows.Add(column1, column2, column3, column4, column5);
                            }
                        }
                    }
                }
            }
        }






        //give student stails for a month
        public static List<StudentPaymentDetails> GetPaymentDetailsByStudentIDAndMonth(int studentID, string month)
        {
            List<StudentPaymentDetails> paymentList = new List<StudentPaymentDetails>();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string sql = @"SELECT p.Payment_ID, s.St_Name, c.Class_ID, CONCAT(t.Tutor_Name, ' - ', su.Sub_Name, ' (', c.Type, ')') AS ClassName, p.Month1, p.Payment_date, c.Fess_Amount
                            FROM Fees p
                            INNER JOIN Student s ON p.St_ID = s.Student_ID
                            INNER JOIN Class c ON p.Class_ID = c.Class_ID
                            INNER JOIN Tutor t ON c.Tut_ID = t.Tutor_ID
                            INNER JOIN Subject su ON c.Sub_ID = su.Sub_ID
                            WHERE s.Student_ID = @studentID AND p.Month1 = @month";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.Parameters.AddWithValue("@month", month);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StudentPaymentDetails paymentDetails = new StudentPaymentDetails
                                {
                                    Student_Name = reader["St_Name"].ToString(),
                                    Class_ID = reader["Class_ID"].ToString(),
                                    ClassName = reader["ClassName"].ToString(),
                                    Month = reader["Month1"].ToString(),
                                    Payment_Date = reader["Payment_date"].ToString(),
                                    Fee_Amount = Convert.ToInt32(reader["Fess_Amount"])
                                };

                                paymentList.Add(paymentDetails);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving payment details: " + ex.Message);
            }

            return paymentList;
        }

        //add payment details
        public static bool AddFees(int studentID, string classID, string month, string paymentDate)
        {
            bool success = false;

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string sql = @"INSERT INTO Fees (St_ID, Class_ID, Month1, Payment_date)
                            VALUES (@studentID, @classID, @month, @paymentDate)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.Parameters.AddWithValue("@classID", classID);
                        command.Parameters.AddWithValue("@month", month);
                        command.Parameters.AddWithValue("@paymentDate", paymentDate);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            success = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while adding fees: " + ex.Message);
            }

            return success;
        }



    }
}
