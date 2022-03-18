using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem.DomainLayer
{
    public class Registration
    {
        [Key]
        public int Registration_Id { get; set; }

        public string Course_StartDate { get; set; }

        public int Course_Id { get; set; }

        public int student_ID{get;set;}
    }
}
