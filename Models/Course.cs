using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace studentInformation.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }      // Brief description of the course
        public int Credits { get; set; }             // Number of credits for the course

        // Foreign key to Teacher
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        // Navigation property
        public ICollection<Student> Students { get; set; }
    }
}