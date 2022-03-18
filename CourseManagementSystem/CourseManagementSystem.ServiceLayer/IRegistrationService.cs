using CourseManagementSystem.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem.ServiceLayer
{
 public   interface IRegistrationService
    {
        IList<RegisteredStudentList> AllRegisteredStudent();
        bool Registration(Registration reg);
        bool DeleteRegistraion(int id);
    }
}
