using System;
using System.Collections.Generic;
using System.Data.SQLite;
using ENTITIES;
namespace DAL
{
    public class database
    {
        private static readonly string connectionString = @"Data Source=C:\Users\User\Documents\שושי\סמינר\שנה ו\C#\למידה מרחוק\מטלת סיכום 2\School.db";

        public static List<Students> GetAllStudents()
        {
            var list = new List<Students>();
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Students", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Students
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        HomePhone = reader["HomePhone"].ToString(),
                        BirthdayYear = Convert.ToInt32(reader["BirthdayYear"]),
                        Class = reader["Class"].ToString(),
                        Address = reader["Address"].ToString()
                    });
                }
            }
            return list;
        }

        public static List<Teachers> GetAllTeachers()
        {
            var list = new List<Teachers>();
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Teachers", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Teachers
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        MailAddress = reader["MailAddress"].ToString()
                    });
                }
            }
            return list;
        }

    }
}
