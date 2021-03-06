﻿using demoLog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace demoLog.DAL
{
    public class SchoolContext : DbContext
    {

        public SchoolContext()
            : base("SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<PostItem> Posts { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}