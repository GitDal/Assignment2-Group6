﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_EF_Core.Models
{
    public class StudentCourse
    {
        public string StudentId { get; set; }
        public int CourseId { get; set; }
        public string Semester { get; set; }
        public bool Active { get; set; }

        //Navigational properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
