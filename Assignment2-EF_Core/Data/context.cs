using System;
using Assignment2_EF_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment2_EF_Core.Data
{
    public class context : DbContext
    {
        // Database Sets
        public DbSet<Student> Students;

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            //ob.UseSqlServer();
        }
    }
}
