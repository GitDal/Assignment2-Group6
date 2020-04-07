using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_EF_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2_ASP_NET.Controllers
{
    public class CreateController : Controller
    {
        //Repository

        // View that redirects to all creation-forms, to create specific entities
        public IActionResult Index()
        {
            return View();
        }

        //Create Course
        public IActionResult Course()
        {
            var course = new Course();

            return View(course);
        }

        [HttpPost]
        public async Task<IActionResult> Course(Course course)
        {

        }

        //Create Student
        public IActionResult Student()
        {
            var student = new Student();

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Student(Student student)
        {
            
        }

        //Resten af create aktionerne
    }
}