using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;
using Assignment2_ASP_NET.Database.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment2_ASP_NET.Controllers
{
    public class CreateController : Controller
    {
        //UnitOfWork
        private readonly IUnitOfWork _unitOfWork;

        public CreateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // View that redirects to all creation-forms, to create specific entities
        // GET: /Create/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Create/Course
        public IActionResult Course()
        {
            var course = new Course();

            return View(course);
        }

        [HttpPost]
        public IActionResult Course(Course course)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.CourseRepository.Add(course);
                    _unitOfWork.Save();
                }
                catch (DbUpdateException ex)
                {
                    return View();
                }

                return View("Index"); //Success
            }
            else
            {
                return View();
            }

        }

        // GET: /Create/Student
        public IActionResult Student()
        {
            var student = new Student();

            return View(student);
        }

        [HttpPost]
        public IActionResult Student(Student student)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.StudentRepository.Add(student);
                return View("Index");
            }
            else
            {
                return View();
            }
        }

        //Resten af create aktionerne
    }
}