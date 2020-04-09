using System;
using Assignment2_ASP_NET.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment2_ASP_NET.Database.Data
{
    public class Context : DbContext
    {
        // Database Sets
        public DbSet<Student> Students;
        public DbSet<Teacher> Teachers;
        public DbSet<Course> Courses;
        public DbSet<Exercise> Exercises;
        public DbSet<Assignment> Assignments;

        public Context(DbContextOptions<Context> options) : base(options)
        { }

        //protected override void OnConfiguring(DbContextOptionsBuilder ob)
        //{
        //    //ob.UseSqlServer();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /**************/
            //  Students  //
            /**************/
            modelBuilder.Entity<Student>().HasKey(p => p.AuId);
            modelBuilder.Entity<Student>()
                .HasMany<Exercise>()
                .WithOne(s => s.Student)
                .HasForeignKey(f => f.StudentId);

            /**************/
            //  Exercise  //
            /**************/
            modelBuilder.Entity<Exercise>().HasKey(p => new {p.Lecture, p.Number});

            /****************/
            //  Assignment  //
            /****************/
            modelBuilder.Entity<Assignment>().HasKey(p => p.Name);

            /**************/
            //  Teachers  //
            /**************/
            modelBuilder.Entity<Teacher>().HasKey(p => p.AuId);
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
            modelBuilder.Entity<TeacherCourse>().HasKey(tc => new { tc.TeacherId, tc.CourseId });
            modelBuilder.Entity<TeacherCourse>()
                .HasOne<Teacher>()
                .WithMany(c => c.Courses)
                .HasForeignKey(f => f.TeacherId);
            modelBuilder.Entity<TeacherCourse>()
                .HasOne<Course>()
                .WithMany(t => t.Teachers)
                .HasForeignKey(f => f.CourseId);

            /********************/
            //  StudentCourses  //
            /********************/
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<StudentCourse>()
                .HasOne<Student>()
                .WithMany(c => c.Courses)
                .HasForeignKey(f => f.StudentId);
            modelBuilder.Entity<StudentCourse>()
                .HasOne<Course>()
                .WithMany(s => s.Students)
                .HasForeignKey(f => f.CourseId);

            /************************/
            //  StudentAssignments  //
            /************************/
            modelBuilder.Entity<StudentAssignment>().HasKey(p => new {p.StudentId, p.AssignmentName});
            modelBuilder.Entity<StudentAssignment>()
                .HasOne<Student>()
                .WithMany(a => a.Assignments)
                .HasForeignKey(f => f.StudentId);
            modelBuilder.Entity<StudentAssignment>()
                .HasOne<Assignment>()
                .WithMany(s => s.Students)
                .HasForeignKey(f => f.AssignmentName);
        }
    }
}
