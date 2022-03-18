using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem.DomainLayer
{
   public class RegisteredStudentList
    {
        [Key]
        public int registered_id { get; set; }
        public string Name { get; set; }

        public string email { get; set; }

        public string courseName { get; set; }

        public string courseDuration { get; set; }

        public string start_Date { get; set; }
    }
}
