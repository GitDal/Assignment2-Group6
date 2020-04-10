using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment2_ASP_NET.Models
{
    public class ExerciseViewModel
    {
        public ExerciseViewModel(IEnumerable<Course> courses, IEnumerable<Teacher> teachers,
            IEnumerable<Student> students)
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

            // StudentId's
            List<string> studentIdList = new List<string>();

            foreach (var student in students)
            {
                studentIdList.Add(student.AuId);
            }
            
            StudentIdList = new SelectList(studentIdList);
        }

        public Exercise Exercise { get; set; }

        //For dropdown select-Lists
        public SelectList CourseIdList { get; set; }
        public SelectList TeacherIdList { get; set; }
        public SelectList StudentIdList { get; set; }
    }
}
