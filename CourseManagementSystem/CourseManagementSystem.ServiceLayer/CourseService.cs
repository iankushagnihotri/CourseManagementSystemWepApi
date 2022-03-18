using CourseManagementSystem.DomainLayer;
using CourseManagementSystem.RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem.ServiceLayer
{
    public class CourseService : ICourseService
    {
        private CourseDbContext courseDbContext;

        public CourseService(CourseDbContext _appDbContext)
        {
            courseDbContext = _appDbContext;
        }



        #region ALL COURSE
        public IList<Course> GetAllCourse()
        {
            return courseDbContext.Set<Course>().ToList();

        }

        #endregion



        #region DELETE COURSE
        public bool DeleteCourse(int id)
        {
            Course cust = courseDbContext.Find<Course>(id);
            if (cust != null)
            {
                courseDbContext.Remove<Course>(cust);
                courseDbContext.SaveChanges();
                return true;
            }
            return false;
        }
        #endregion



        #region ADD COURSES
        public bool AddCourse(Course cust)
        {
            courseDbContext.Add<Course>(cust);
            if (courseDbContext.SaveChanges() > 0)
            {
                return true;
            }
            return false;

        }
        #endregion









    }
}

