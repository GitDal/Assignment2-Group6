using System;
using Assignment2_EF_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment2_EF_Core.Data
{
    public class Context : DbContext
    {
        // Database Sets
        public DbSet<Student> Students;
        public DbSet<Teacher> Teachers;
        public DbSet<Course> Courses;
        public DbSet<Exercise> Exercises;
        public DbSet<Assignment> Assignments;

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            //ob.UseSqlServer();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /**************/
            //  Students  //
            /**************/
            modelBuilder.Entity<Student>().HasKey(p => p.auId);








            /**************/
            //  Teachers  //
            /**************/
            modelBuilder.Entity<Teacher>()
                .HasMany<Assignment>()
                .WithOne(t => t.Teacher)
                .HasForeignKey(f => f.TeacherId);
            modelBuilder.Entity<Teacher>()
                .HasMany<Exercise>()
                .WithOne(t => t.Teacher)
                .HasForeignKey(f => f.TeacherId);

            /*************/
            //  Courses  //
            /*************/
            modelBuilder.Entity<Course>().HasKey(p => p.CourseId);
            modelBuilder.Entity<Course>()
                .HasMany<Assignment>()
                .WithOne(c => c.Course)
                .HasForeignKey(f => f.CourseId);
            modelBuilder.Entity<Course>()
                .HasMany<Exercise>()
                .WithOne(c => c.Course)
                .HasForeignKey(f => f.CourseId);
            
            /********************/
            //  TeacherCourses  //
            /********************/
            modelBuilder.Entity<TeacherCourse>()
                .HasOne<Teacher>()
                .WithMany(c => c.Courses)
                .HasForeignKey(f => f.CourseId);
            modelBuilder.Entity<TeacherCourse>()
                .HasOne<Course>()
                .WithMany(t => t.Teachers)
                .HasForeignKey(f => f.TeacherId);

            /********************/
            //  StudentCourses  //
            /********************/
            modelBuilder.Entity<StudentCourse>()
                .HasOne<Student>()
                .WithMany(c => c.Courses)
                .HasForeignKey(f => f.StudentId);
            modelBuilder.Entity<StudentCourse>()
                .HasOne<Course>()
                .WithMany(s => s.Students)
                .HasForeignKey(f => f.CourseId);
        }
    }
}
