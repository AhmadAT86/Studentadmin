using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WU15.StudentAdministration.Web.Models;

namespace WU15.StudentAdministration.Web.Controllers.DataAccess
{
    public class DefaultDataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(DbModelBulider modelBulider)

        {
            base.OnModelCreating(modelBuilder);
        }
    }
}