using System.Collections.Generic;
using System.Data.Entity;
using DAL;
using ENTITIES;
namespace BLL
{
    public class fun
    {
        public static List<Students> GetStudents()
        {
            return database.GetAllStudents();
        }

        public static List<Teachers> GetTeachers()
        {
            return database.GetAllTeachers();
        }
    }
}
