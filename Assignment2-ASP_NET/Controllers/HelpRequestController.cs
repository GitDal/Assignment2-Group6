using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;
using Assignment2_ASP_NET.Database.Repository;
using Assignment2_ASP_NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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

        public IActionResult GetForTeacherCourse(string teacherAuId, string courseId)
        {
            var exerciseHelpRequests = _unitOfWork.ExerciseRepository.Find(p =>
                (p.TeacherId == teacherAuId) && (p.CourseId == courseId));

            var assignmentHelpRequests = _unitOfWork.AssignmentRepository.Find(p =>
                (p.TeacherId == teacherAuId) && (p.CourseId == courseId));

            var teacher = _unitOfWork.TeacherRepository.Get(teacherAuId);
            var course = _unitOfWork.CourseRepository.Get(courseId);
            
            return View(new TeacherCourseHelpRequestViewModel(exerciseHelpRequests, assignmentHelpRequests, teacher, course));
        }

        public IActionResult Statistics()
        {


            return View();
        }


    }
}