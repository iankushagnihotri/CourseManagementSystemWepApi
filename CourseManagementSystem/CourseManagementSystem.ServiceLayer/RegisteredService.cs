using CourseManagementSystem.DomainLayer;
using CourseManagementSystem.RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem.ServiceLayer
{
    public class RegisteredService : IRegistrationService
    {
         private CourseDbContext courseDbContext;

        public RegisteredService(CourseDbContext _appDbContext)
        {
            courseDbContext = _appDbContext;
        }


        #region DELETE COURSE

        public bool DeleteRegistraion(int id)
        {
            Registration cust = courseDbContext.Find<Registration>(id);
            if (cust != null)
            {
                courseDbContext.Remove<Registration>(cust);
                courseDbContext.SaveChanges();
                return true;
            }
            return false;
               
            
        }
        #endregion




        #region AllRegisteredStudent
        public IList<RegisteredStudentList> AllRegisteredStudent()
       {
            var reg = (from  res in courseDbContext.register

                       join c in courseDbContext.courses
                       on  res.Course_Id equals c.Course_Id
                       join s in courseDbContext.students
                       on res.student_ID equals s.student_Id
 

                    select new RegisteredStudentList {
                        registered_id=res.Registration_Id,
                        Name=s.Student_Name,
                        email=s.Email,
                        courseName=c.Course_Name,
                        courseDuration=c.Course_Duration,
                        start_Date=res.Course_StartDate

                    }).ToList();
            return reg;
        }
        #endregion



        #region AddRegistration
        public bool Registration(Registration reg)
        {
            courseDbContext.Add<Registration>(reg);
            if (courseDbContext.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
        #endregion





    }
}
