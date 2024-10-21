using Microsoft.AspNetCore.Mvc;
using studentInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace studentInformation.Controllers
{
    public class StudentController : Controller
    {
       
        public ActionResult Index()
        {
         
            var teacher1 = new Teacher
            {
                TeacherId = 1,
                TeacherName = "Mr. Smith",
                Email = "smith@example.com",
                PhoneNumber = "555-1234",
                Department = "Mathematics"
            };

            var teacher2 = new Teacher
            {
                TeacherId = 2,
                TeacherName = "Mrs. Johnson",
                Email = "johnson@example.com",
                PhoneNumber = "555-5678",
                Department = "History"
            };

          
            var course1 = new Course
            {
                CourseId = 1,
                CourseName = "Math 101",
                Description = "Introduction to Mathematics",
                Credits = 3,
                Teacher = teacher1
            };

            var course2 = new Course
            {
                CourseId = 2,
                CourseName = "History 201",
                Description = "Exploration of World History",
                Credits = 4,
                Teacher = teacher2
            };

           
            var student1 = new Student
            {
                StudentId = 1,
                StudentName = "Araf",
                DOB = new DateTime(2000, 5, 15), 
                DOJ = new DateTime(2018, 9, 1),  
                Courses = new List<Course> { course1, course2 }
            };

            var student2 = new Student
            {
                StudentId = 2,
                StudentName = "Nobab",
                DOB = new DateTime(2001, 4, 10),
                DOJ = new DateTime(2019, 9, 1),  
                Courses = new List<Course> { course1 }
            };

            var students = new List<Student> { student1, student2 };

           
            return View(students);
        }
    }
    }
    
