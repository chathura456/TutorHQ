using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorHQ.Models;

namespace TutorHQ.Controllers
{
    public class AttendenceControllers : DBconnection
    {
        //get all attendenc details
        public static List<AttendanceDetails> GetAttendanceDetails(string classID, string day)
        {
            List<AttendanceDetails> attendanceList = new List<AttendanceDetails>();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string sql = @"SELECT date1, time1, St_ID, CASE WHEN St_ID IS NOT NULL THEN 'Attend' ELSE 'No-Attend' END AS Status
                            FROM Attendence
                            WHERE Class_ID = @classID AND date1 = @day";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@classID", classID);
                        command.Parameters.AddWithValue("@day", day);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AttendanceDetails attendanceDetails = new AttendanceDetails
                                {
                                    Date = reader["date1"].ToString(),
                                    Time = reader["time1"].ToString(),
                                    StudentID = reader["St_ID"] != DBNull.Value ? Convert.ToInt32(reader["St_ID"]) : 0,
                                    Status = reader["Status"].ToString()
                                };

                                attendanceList.Add(attendanceDetails);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving attendance details: " + ex.Message);
            }

            return attendanceList;
        }

        //get all attendenc details for a student given month and class
        public static List<AttendanceDetails> GetAttendanceDetailsByStudent(int studentID, string month, string classID)
        {
            List<AttendanceDetails> attendanceList = new List<AttendanceDetails>();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string sql = @"SELECT date1, time1, CASE WHEN St_ID = @studentID THEN 'Attend' ELSE 'No-Attend' END AS Status
                            FROM Attendence
                            WHERE Class_ID = @classID AND MONTH(date1) = MONTH(@month) AND YEAR(date1) = YEAR(@month)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.Parameters.AddWithValue("@classID", classID);
                        command.Parameters.AddWithValue("@month", month);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AttendanceDetails attendanceDetails = new AttendanceDetails
                                {
                                    Date = reader["date1"].ToString(),
                                    Time = reader["time1"].ToString(),
                                    StudentID = studentID,
                                    Status = reader["Status"].ToString()
                                };

                                attendanceList.Add(attendanceDetails);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving attendance details: " + ex.Message);
            }

            return attendanceList;
        }

    }
}
