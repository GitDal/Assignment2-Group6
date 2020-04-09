using System;
using System.Collections.Generic;
using System.Text;
using Assignment2_ASP_NET.Database.Data;
using Assignment2_ASP_NET.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment2_ASP_NET.Database.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public IGenericRepository<Course> CourseRepository { get; }
        public IGenericRepository<Student> StudentRepository { get; }
        public IGenericRepository<Teacher> TeacherRepository { get; }
        public IGenericRepository<Assignment> AssignmentRepository { get; }
        public IGenericRepository<Exercise> ExerciseRepository { get; }

        public UnitOfWork(DbContext context)
        {
            _context = context;

            CourseRepository = new GenericRepository<Course>(context);
            StudentRepository = new GenericRepository<Student>(context);
            TeacherRepository = new GenericRepository<Teacher>(context);
            AssignmentRepository = new GenericRepository<Assignment>(context);
            ExerciseRepository = new GenericRepository<Exercise>(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
