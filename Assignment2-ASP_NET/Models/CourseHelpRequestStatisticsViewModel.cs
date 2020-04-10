using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;

namespace Assignment2_ASP_NET.Models
{
    public class CourseHelpRequestStatisticsViewModel
    {
        public CourseHelpRequestStatisticsViewModel() { }
        public Course Course { get; set; }
        public int AmountExercise { get; set; }
        public int AmountAssignment { get; set; }
    }
}
