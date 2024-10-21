using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace studentInformation.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string Email { get; set; }           // Email of the teacher
        public string PhoneNumber { get; set; }     // Contact number of the teacher
        public string Department { get; set; }       // Department of the teacher

        // Navigation property
        public ICollection<Course> Courses { get; set; }
    }
}