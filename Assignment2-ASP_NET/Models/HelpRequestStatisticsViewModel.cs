using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;

namespace Assignment2_ASP_NET.Models
{
    public class HelpRequestStatisticsViewModel
    {
        public HelpRequestStatisticsViewModel() { }

        public List<HelpRequestCourseStatistics> CourseStatisticsList { get; set; }
    }

    public class HelpRequestCourseStatistics
    {
        public HelpRequestCourseStatistics()
        { }

        public Course Course { get; set; }
        public int ExerciseAmount { get; set; }
        public int AssignmentAmount { get; set; }
        public int OpenAmount { get; set; }
    }
}
