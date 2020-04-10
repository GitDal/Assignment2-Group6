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
            var courses = _unitOfWork.CourseRepository.GetAll();
            var teachers = _unitOfWork.TeacherRepository.GetAll();
            var students = _unitOfWork.StudentRepository.GetAll();

            var vm = new BrowseViewModel(courses, teachers, students);

            return View(vm);
        }

        public IActionResult GetForStudent(string studentAuId)
        {
            var student = _unitOfWork.StudentRepository.Get(studentAuId);

            if (student != null)
            {
                var vm = new StudentHelpRequestsViewModel();

                // Get student
                vm.Student = student;

                // Help requests (exercises and assignments) for student
                vm.Exercises = _unitOfWork.ExerciseRepository.Find(e => e.StudentId == studentAuId);

                var studentAssignments = _unitOfWork.StudentAssignmentRepository.Find(sa => sa.StudentId == studentAuId);

                List<Assignment> assignments = new List<Assignment>();
                
                foreach(var studentAssignment in studentAssignments)
                {
                    assignments.Add(_unitOfWork.AssignmentRepository.Get(studentAssignment.AssignmentName));
                }

                vm.Assignments = assignments;

                return View(vm); //Success
            }

            return View("Index"); //Error

        }

        public IActionResult GetForTeacherCourse(string teacherAuId, string courseId)
        {
            var teacher = _unitOfWork.TeacherRepository.Get(teacherAuId);
            var course = _unitOfWork.CourseRepository.Get(courseId);

            if (teacher != null && course != null)
            {
                var exerciseHelpRequests = _unitOfWork.ExerciseRepository.Find(p =>
                    (p.TeacherId == teacherAuId) && (p.CourseId == courseId));

                var assignmentHelpRequests = _unitOfWork.AssignmentRepository.Find(p =>
                    (p.TeacherId == teacherAuId) && (p.CourseId == courseId));

                return View(new TeacherCourseHelpRequestViewModel(exerciseHelpRequests, assignmentHelpRequests, teacher, course)); //Success
            }

            return View("Index"); // Error
        }

        public IActionResult Statistics(string courseId)
        {
            var course = _unitOfWork.CourseRepository.Get(courseId);

            if (course != null)
            {
                var vm = new CourseHelpRequestStatisticsViewModel();

                vm.Course = course;

                var exercises = _unitOfWork.ExerciseRepository.Find(e => e.CourseId == courseId);
                var assignments = _unitOfWork.AssignmentRepository.Find(a => a.CourseId == courseId);

                vm.AmountExercise = exercises.Count();
                vm.AmountAssignment = assignments.Count();

                return View(vm);
            }

            return View("Index");
        }


    }
}