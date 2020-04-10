using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;
using Assignment2_ASP_NET.Database.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment2_ASP_NET.Models;

namespace Assignment2_ASP_NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult PopulateDatabase()
        {
            //Deleting everything in database before populating the database
            _unitOfWork.StudentAssignmentRepository.DeleteRange(_unitOfWork.StudentAssignmentRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.AssignmentRepository.DeleteRange(_unitOfWork.AssignmentRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.ExerciseRepository.DeleteRange(_unitOfWork.ExerciseRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.StudentCourseRepository.DeleteRange(_unitOfWork.StudentCourseRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.StudentRepository.DeleteRange(_unitOfWork.StudentRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.TeacherCourseRepository.DeleteRange(_unitOfWork.TeacherCourseRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.TeacherRepository.DeleteRange(_unitOfWork.TeacherRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.CourseRepository.DeleteRange(_unitOfWork.CourseRepository.GetAll());
            _unitOfWork.Save();
            /***************************************************************/

            _unitOfWork.CourseRepository.AddRange(Seeder.SeedCourses());
            _unitOfWork.Save();

            _unitOfWork.TeacherRepository.AddRange(Seeder.SeedTeachers());
            _unitOfWork.Save();

            _unitOfWork.TeacherCourseRepository.AddRange(Seeder.SeedTeacherCourses());
            _unitOfWork.Save();

            _unitOfWork.StudentRepository.AddRange(Seeder.SeedStudents());
            _unitOfWork.Save();

            _unitOfWork.StudentCourseRepository.AddRange(Seeder.SeedStudentCourses());
            _unitOfWork.Save();

            _unitOfWork.ExerciseRepository.AddRange(Seeder.SeedExercises());
            _unitOfWork.Save();

            _unitOfWork.AssignmentRepository.AddRange(Seeder.SeedAssignments());
            _unitOfWork.Save();

            _unitOfWork.StudentAssignmentRepository.AddRange(Seeder.SeedStudentAssignments(_unitOfWork.AssignmentRepository.GetAll()));
            _unitOfWork.Save();

            return View("Index");
        }

        public IActionResult ClearDatabase()
        {
            _unitOfWork.StudentAssignmentRepository.DeleteRange(_unitOfWork.StudentAssignmentRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.AssignmentRepository.DeleteRange(_unitOfWork.AssignmentRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.ExerciseRepository.DeleteRange(_unitOfWork.ExerciseRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.StudentCourseRepository.DeleteRange(_unitOfWork.StudentCourseRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.StudentRepository.DeleteRange(_unitOfWork.StudentRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.TeacherCourseRepository.DeleteRange(_unitOfWork.TeacherCourseRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.TeacherRepository.DeleteRange(_unitOfWork.TeacherRepository.GetAll());
            _unitOfWork.Save();
            _unitOfWork.CourseRepository.DeleteRange(_unitOfWork.CourseRepository.GetAll());
            _unitOfWork.Save();
            
            return View("Index");
        }
    }
}
