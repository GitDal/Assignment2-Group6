using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;
using Assignment2_ASP_NET.Database.Repository;
using Assignment2_ASP_NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2_ASP_NET.Controllers
{
    public class HelpRequestController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HelpRequestController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetForStudent(string studentAuId)
        {
            var vm = new StudentHelpRequestsViewModel();

            // Get student
            var student = _unitOfWork.StudentRepository.Get(studentAuId);
            
            // Help requests (exercises and assignments) for student
            vm.Exercises = _unitOfWork.ExerciseRepository.Find(e => e.StudentId == studentAuId);
            vm.Assignments =
                _unitOfWork.AssignmentRepository.Find(a => a.Students.Exists(sa => sa.StudentId == studentAuId));

            return View(vm);
        }

        public IActionResult GetForTeacherCourse(string teacherAuId, int courseId)
        {


            return View();
        }

        public IActionResult Statistics()
        {


            return View();
        }


    }
}