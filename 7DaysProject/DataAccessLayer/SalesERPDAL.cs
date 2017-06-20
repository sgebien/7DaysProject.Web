using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _7DaysProject.Models;

namespace _7DaysProject.DataAccessLayer
{
    public class SalesERPDAL:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("tblEmployee");
            base.OnModelCreating(modelBuilder);
        }
    }
}