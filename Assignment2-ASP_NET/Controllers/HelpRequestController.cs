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
            
            // Help requests for student
            vm.Exercises = _unitOfWork.ExerciseRepository.Find(e => e.);
            vm.Assignments =
                _unitOfWork.AssignmentRepository.Find(a =>
                    a.StudentAssignments.Find(sa => sa.StudentId.Equals(studentAuId)));

            return View()
        }

        public IActionResult GetForTeacherCourse(string teacherAuId, int courseId)
        {

        }

        public IActionResult Statistics()
        {


            return View();
        }


    }
}