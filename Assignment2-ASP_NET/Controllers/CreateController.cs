using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;
using Assignment2_ASP_NET.Database.Repository;
using Assignment2_ASP_NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            //_unitOfWork.CourseRepository.Add(new Course() { CourseId = "GUI", Name = "GUI programming" });
            //_unitOfWork.Save();
            var course = new Course();

            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Course(Course course)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CourseRepository.Add(course);
                _unitOfWork.Save();

                return View("Index"); //Success
            }
            else
            {
                return View(); //Fail
            }

        }

        // GET: /Create/Student
        public IActionResult Student()
        {
            var student = new Student();
            var courses = _unitOfWork.CourseRepository.GetAll();

            var studentViewModel = new StudentViewModel();

            studentViewModel.Student = student;

            foreach (var course in courses)
            {
                studentViewModel.Courses.Add(new CourseSignUp()
                {
                    CourseTag = course.CourseId,
                    IsSignedUp = false
                });
            }


            return View(studentViewModel);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Student(StudentViewModel studentViewModel)
        {
            if (ModelState.IsValid)
            {

                _unitOfWork.StudentRepository.Add(studentViewModel.Student);
                foreach (var c in studentViewModel.Courses)
                {
                    if (c.IsSignedUp)
                    {
                        _unitOfWork.StudentCourseRepository.Add(new StudentCourse()
                        {
                            Active = true,
                            CourseId = c.CourseTag,
                            Semester = studentViewModel.Semester,
                            StudentId = studentViewModel.Student.AuId
                        });
                    }
                }
                _unitOfWork.Save();
                return View("Index");
            }
            else
            {
                return View();
            }
        }
        

        // GET: /Create/Teacher
        public IActionResult Teacher()
        {
            var teacher = new Teacher();

            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Teacher(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.TeacherRepository.Add(teacher);
                _unitOfWork.Save();
                return View("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: /Create/Exercise
        public IActionResult Exercise()
        {
            var courses = _unitOfWork.CourseRepository.GetAll();
            var teachers = _unitOfWork.TeacherRepository.GetAll();
            var students = _unitOfWork.StudentRepository.GetAll();

            var vm = new ExerciseViewModel(courses, teachers, students);

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Exercise(Exercise exercise)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ExerciseRepository.Add(exercise);
                _unitOfWork.Save();
                return View("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: /Create/Assignment
        public IActionResult Assignment()
        {
            var courses = _unitOfWork.CourseRepository.GetAll();
            var teachers = _unitOfWork.TeacherRepository.GetAll();
            var students = _unitOfWork.StudentRepository.GetAll();

            var vm = new AssignmentViewModel(courses, teachers, students); //Populating Lists in ViewModel

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Assignment(AssignmentViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.AssignmentRepository.Add(vm.Assignment);

                foreach (var student in vm.Students)
                {
                    if (student.IsCollaborator) //If checkBox is checked we make new relationship (in shadow-table)
                    {
                        _unitOfWork.StudentAssignmentRepository.Add(new StudentAssignment()
                        {
                            StudentId = student.StudentId,
                            AssignmentName = vm.Assignment.Name
                        });
                    }
                }

                _unitOfWork.Save();
                return View("Index");
            }
            else
            {
                return View();
            }
        }
    }
}