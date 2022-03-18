using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem.DomainLayer
{
    public class Student
    {
        
        [Key]
        public int student_Id { get; set; }
        public string Student_Name { get; set; }

        public int Contact_No {get;set;}

        public string Email { get; set; }
    }
}
