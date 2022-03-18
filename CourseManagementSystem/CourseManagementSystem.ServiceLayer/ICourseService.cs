using CourseManagementSystem.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem.ServiceLayer
{
    public interface ICourseService
    {
        IList<Course> GetAllCourse();


        bool AddCourse(Course cust);

        bool DeleteCourse(int id);




    }
}
