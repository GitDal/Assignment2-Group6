using System;
using System.Collections.Generic;
using System.Text;
using Assignment2_EF_Core.Models;

namespace Assignment2_EF_Core.Repository
{
    public interface IRepository
    {
        void AddStudent(Student student);
        void AddTeacher(Teacher teacher);
        void AddCourse(Course course);
        void AddExercise(Exercise exercise);
        void AddAssignment(Assignment assignment);

        /*
        void AddReview(Review review);
        void AddHelpRequest(HelpRequest helpRequest);
        */
    }
}
