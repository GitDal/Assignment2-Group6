﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment2_EF_Core.Models
{
    public class Teacher
    {
        [Required]
        public string auId { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }

        //Navigational properties
        public List<TeacherCourse> Courses { get; set; }
        public List<Exercise> Exercises { get; set; }
        public List<Assignment> Assignments { get; set; }
    }
}