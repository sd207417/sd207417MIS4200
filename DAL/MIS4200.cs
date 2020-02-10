using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using sd207417MIS4200.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object

namespace sd207417MIS4200.DAL
{
    public class MIS4200 : DbContext
    {
        public MIS4200() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200,
                sd207417MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}