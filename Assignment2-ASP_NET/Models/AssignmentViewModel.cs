using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;
using Assignment2_ASP_NET.Database.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment2_ASP_NET.Models
{
    public class AssignmentViewModel
    {
        public AssignmentViewModel(IEnumerable<Course> courses, IEnumerable<Teacher> teachers, IEnumerable<Student> students)
        {
            /* Populate lists */

            // CourseId's
            List<string> courseIdList = new List<string>();

            foreach (var course in courses)
            {
                courseIdList.Add(course.CourseId);
            }

            CourseIdList = new SelectList(courseIdList);

            // TeacherId's
            List<string> teacherIdList = new List<string>();

            foreach (var teacher in teachers)
            {
                teacherIdList.Add(teacher.AuId);
            }

            TeacherIdList = new SelectList(teacherIdList);

            Students = new List<StudentCollaborators>();

            // StudentId's
            foreach (var student in students)
            {
                Students.Add(new StudentCollaborators()
                {
                    StudentId = student.AuId,
                    IsCollaborator = false
                });
            }
        }

        public Assignment Assignment { get; set; }

        //For dropdown select-Lists
        public SelectList CourseIdList { get; set; }
        public SelectList TeacherIdList { get; set; }

        //For shadow table Students
        public List<StudentCollaborators> Students { get; set; }
    }

    public class StudentCollaborators
    {
        public string StudentId { get; set; }
        public bool IsCollaborator { get; set; }
    }
}
