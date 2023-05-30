using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDGS904_BD.Models
{
    public class Student
    {
        [Required]
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string name { get; set; }
        [Required]
        [StringLength(255)]
        public string lastName { get; set; }
        [StringLength(255)]
        public string email { get; set; }
    }
}