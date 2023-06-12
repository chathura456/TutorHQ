using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorHQ.Models;

namespace TutorHQ.Controllers
{
    public class ScheduleController : DBconnection
    {
        //get all schedule details
        public static List<ScheduleDetails> GetAllScheduleDetails()
        {
            List<ScheduleDetails> scheduleList = new List<ScheduleDetails>();

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string sql = @"SELECT c.Class_ID, CONCAT(t.Tutor_Name, ' - ', s.Sub_Name, ' (', c.Type, ')') AS ClassName, s.Day1, s.Time_From, s.Time_To, s.Hall_No
                            FROM Schedules s
                            INNER JOIN Class c ON s.Class_ID = c.Class_ID
                            INNER JOIN Tutor t ON c.Tut_ID = t.Tutor_ID
                            INNER JOIN Subject su ON c.Sub_ID = su.Sub_ID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ScheduleDetails scheduleDetails = new ScheduleDetails
                                {
                                    Class_ID = reader["Class_ID"].ToString(),
                                    ClassName = reader["ClassName"].ToString(),
                                    Day = reader["Day1"].ToString(),
                                    Time_From = reader["Time_From"].ToString(),
                                    Time_To = reader["Time_To"].ToString(),
                                    Hall_No = reader["Hall_No"].ToString()
                                };

                                scheduleList.Add(scheduleDetails);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving schedule details: " + ex.Message);
            }

            return scheduleList;
        }

    }
}
