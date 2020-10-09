using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataAccessLayer.DataContext
{
    public class DatabaseContext : DbContext
    {
        public class OptionsBuild
        {
            private AppConfiguration Settings { get; set; }
            public DbContextOptions<DatabaseContext> DbOptions { get; set; }
            public DbContextOptionsBuilder<DatabaseContext> OpsBuilder { get; set; }

            public OptionsBuild()
            {
                Settings = new AppConfiguration();

                OpsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                OpsBuilder.UseSqlServer(Settings.SqlConnectionString);

                DbOptions = OpsBuilder.Options;
            }
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            : base(options) 
        { 
        }

        // List of the DbSet that is used in the system
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Training> Trainings { get; set; }
    }
}
