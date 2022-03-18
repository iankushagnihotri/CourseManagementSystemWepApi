using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem.DomainLayer
{
    public class Course
    {
        [Key]

        public int Course_Id { get; set; }

        public string Course_Name { get; set; }

        public string Course_Duration { get; set; }

        public string Course_Instructor { get; set; }


        public string Course_Description { get; set; }
    }
}

