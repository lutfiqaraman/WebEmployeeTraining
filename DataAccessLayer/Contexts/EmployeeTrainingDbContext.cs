using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Contexts
{
    public class EmployeeTrainingDbContext : DbContext
    {
        public EmployeeTrainingDbContext(DbContextOptions<EmployeeTrainingDbContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Training> Trainings { get; set; }
    }
}
