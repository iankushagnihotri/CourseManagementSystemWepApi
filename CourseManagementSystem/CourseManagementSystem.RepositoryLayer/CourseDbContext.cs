using CourseManagementSystem.DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem.RepositoryLayer
{
    public class CourseDbContext : DbContext
    {
        public object student;

        public CourseDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Course> courses { get; set; }
        public DbSet<Registration> register { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<RegisteredStudentList> registerstudent { get; set; }
    }
}
