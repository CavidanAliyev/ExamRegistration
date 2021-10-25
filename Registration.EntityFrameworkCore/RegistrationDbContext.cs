using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Registration.Domain.Exams;
using Registration.Domain.Lessons;
using Registration.Domain.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.EntityFrameworkCore
{
    public class RegistrationDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public RegistrationDbContext()
        {

        }

        public RegistrationDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var conn = "Server=.\\;Database=Registration;Trusted_Connection=True;MultipleActiveResultSets=true";
            var conn = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>().Property(p => p.LessonCode).HasColumnType("char").HasMaxLength(3);
            modelBuilder.Entity<Exam>().Property(p => p.StudentNumber).HasMaxLength(3);
            modelBuilder.Entity<Lesson>().Property(p => p.Code).HasColumnType("char").HasMaxLength(3);
            modelBuilder.Entity<Lesson>().Property(p => p.Name).HasColumnType("varchar").HasMaxLength(30);
            modelBuilder.Entity<Lesson>().Property(p => p.TeacherFirstName).HasColumnType("varchar").HasMaxLength(20);
            modelBuilder.Entity<Lesson>().Property(p => p.TeacherLastName).HasColumnType("varchar").HasMaxLength(20);
            modelBuilder.Entity<Student>().Property(p => p.FirstName).HasColumnType("varchar").HasMaxLength(30);
            modelBuilder.Entity<Student>().Property(p => p.LastName).HasColumnType("varchar").HasMaxLength(30);
        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
