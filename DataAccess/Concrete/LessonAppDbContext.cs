using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
   public class LessonAppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=LessonAppDb;Trusted_Connection=true");
        }
        public DbSet<Student> STUDENTS { get; set; }
        public DbSet<Teacher> TEACHERS { get; set; }
        public DbSet<Lesson> LESSONS { get; set; }
        public DbSet<Department> DEPARTMENTS { get; set; }
        public DbSet<LessonTeacher> LESSONSTEACHERS { get; set; }
        public DbSet<School> SCHOOLS { get; set; }
        public DbSet<SchoolDepartment> SCHOOLDEPARTMENTS { get; set; }
    }
}
