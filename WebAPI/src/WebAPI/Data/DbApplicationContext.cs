using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {}

        public ApplicationDbContext() : base()
        { }

        public DbSet<Educator> Educator { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<AssingmentType> AssingmentType { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<ClassMember> ClassMember { get; set; }
        public DbSet<ClassPeriod> ClassPeriod { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<GradeBook> GradeBook { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
