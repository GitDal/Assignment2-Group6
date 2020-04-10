using System;
using System.Collections.Generic;
using System.Text;
using Assignment2_ASP_NET.Database.Models;

namespace Assignment2_ASP_NET.Database.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Course> CourseRepository { get; }
        IGenericRepository<Student> StudentRepository { get; }
        IGenericRepository<Teacher> TeacherRepository { get; }
        IGenericRepository<Assignment> AssignmentRepository { get; }
        IGenericRepository<Exercise> ExerciseRepository { get; }
        IGenericRepository<StudentCourse> StudentCourseRepository { get; }


        void Save();
    }
}