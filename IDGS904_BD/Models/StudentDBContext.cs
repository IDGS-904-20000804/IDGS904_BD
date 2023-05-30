using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IDGS904_BD.Models
{
    public class StudentDBContext: DbContext
    {
        public static string connection = "DefaultConnection";
        public StudentDBContext(): base (connection) { }
        public DbSet<Student> Students { get; set; }
    }
}