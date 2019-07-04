using MidOne.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidOne.Context
{
    public class GradeContext : DbContext
    {
        public GradeContext() : base("name=ConnectionString")
        {
            Database.SetInitializer<GradeContext>(new DropCreateDatabaseAlways<GradeContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GradeContext, Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasKey(s => s.Id);
            modelBuilder.Entity<Subject>().HasKey(s => s.Id);
            modelBuilder.Entity<Grade>().HasKey(s => s.Id);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
