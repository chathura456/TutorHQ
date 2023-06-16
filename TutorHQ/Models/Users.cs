using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorHQ.Models
{
    public class Users
    {
        public bool LoginSuccess { get; set; }
        public int UserID { get; set; }
        public string SessionID { get; set; }
        public string Name { get; set; }
    }

    public class CurrentUser
    {
        public static bool LoginSuccess { get; set; }
        public static int UserID { get; set; }
        public static string SessionID { get; set; }
        public static string Name { get; set; }
    }


    public class Subject
    {
        public string Sub_ID { get; set; }
        public string Sub_Name { get; set; }
        public string Stream { get; set; }
    }

    public class ListItem
    {
        public string DisplayText { get; set; }
        public string Value { get; set; }

        public ListItem(string displayText, string value)
        {
            DisplayText = displayText;
            Value = value;
        }

        public override string ToString()
        {
            return DisplayText;
        }
    }


    public class Tutor
    {
        public int Tutor_ID { get; set; }
        public string Tutor_Name { get; set; }
        public int Tutor_Phone { get; set; }
        public string Sub_ID { get; set; }
    }

    public class Class
    {
        public string Class_ID { get; set; }
        public string Type { get; set; }
        public int Fess_Amount { get; set; }
    }

    public class Student
    {
        public int Student_ID { get; set; }
        public string St_Name { get; set; }
        public string Gender { get; set; }
        public string NIC { get; set; }
        public int Phone_NO { get; set; }
        public string Parent_Name { get; set; }
        public string Parent_Relation { get; set; }
        public int? Parent_Phone { get; set; }
        public string Select_Subjects { get; set; }
    }

    public class Attendance
    {
        public string Date1 { get; set; }
        public string Time1 { get; set; }
        public string Class_ID { get; set; }
        public int St_ID { get; set; }
        public Class Class { get; set; }
        public Student Student { get; set; }
    }

    public class Fee
    {
        public int Payment_ID { get; set; }
        public int St_ID { get; set; }
        public string Class_ID { get; set; }
        public string Month1 { get; set; }
        public string Payment_date { get; set; }
        public Student Student { get; set; }
        public Class Class { get; set; }
    }

    public class Schedule
    {
        public string Class_ID { get; set; }
        public string Day1 { get; set; }
        public string Time_From { get; set; }
        public string Time_To { get; set; }
        public string Hall_No { get; set; }
        public Class Class { get; set; }
    }

    public class ClassDetails
    {
        public string Class_ID { get; set; }
        public string Tutor_Name { get; set; }
        public string Subject_Name { get; set; }
        public string Type { get; set; }
    }


    public class StudentPaymentDetails
    {
        public int Student_ID { get; set; }
        public string Student_Name { get; set; }
        public string Class_ID { get; set; }
        public string ClassName { get; set; }
        public string Month { get; set; }
        public string Payment_Date { get; set; }
        public int Fee_Amount { get; set; }
    }

    public class AttendanceDetails
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public int StudentID { get; set; }
        public string Status { get; set; }
    }

    public class ScheduleDetails
    {
        public string Class_ID { get; set; }
        public string ClassName { get; set; }
        public string Day { get; set; }
        public string Time_From { get; set; }
        public string Time_To { get; set; }
        public string Hall_No { get; set; }
    }



}
