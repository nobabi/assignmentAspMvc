using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace studentInformation.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DOB { get; set; }            // Date of Birth
        public DateTime DOJ { get; set; }            // Date of Joining

        // Navigation property
        public ICollection<Course> Courses { get; set; }
    }
}