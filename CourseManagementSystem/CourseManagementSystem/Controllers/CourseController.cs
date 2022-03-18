using CourseManagementSystem.DomainLayer;
using CourseManagementSystem.ServiceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ICourseService courseservice;
        private ILogger<CourseController> ilogger;
        public CourseController(ICourseService _customerservice, ILogger<CourseController> _ilogger)
        {
            ilogger = _ilogger;
            ilogger.LogInformation("Course class called");
            courseservice = _customerservice;
        }

        #region GET ALL COURSES
        [HttpGet]
       [Route("[action]")]
        public ActionResult AllCourse()
        {
            try
            {
                ilogger.LogInformation("Course Endpoint start");
                var cust = courseservice.GetAllCourse();
                if (cust != null && cust.Count >= 0)
                {
                    return Ok(cust);
                }
                ilogger.LogInformation("Course Endpoint ends");
            }

            catch (Exception e)
            {
                ilogger.LogError("Exception Detail :" + e.InnerException);
            }
            return BadRequest("NOT FOUND");
        }
        #endregion


        #region  ADDCOURSES
        [HttpPost]
        [Route("[action]")]
        public ActionResult AddCourse(Course cust)
        {
            try
            {
                ilogger.LogInformation("Course Endpoint start");
                var check = courseservice.AddCourse(cust);
                if (check == true)
                {
                    return Ok("Course is  Added");
                }

                ilogger.LogInformation("Course Endpoint ends");
            }
            catch (Exception e)
            {
                ilogger.LogError("Exception Detail :" + e.InnerException);
            }
            return BadRequest();
        }
        #endregion



        #region DELETECOURSE
        [HttpDelete]
        [Route("[action]/id")]
        public ActionResult DeleteCourse(int id)
        {
            try
            {
                ilogger.LogInformation("Course Endpoint start");
                var check = courseservice.DeleteCourse(id);
                if (check == true)
                {
                    return Ok(" Course is  Deleted");
                }
                ilogger.LogInformation("Course Endpoint ends");
            }
            catch (Exception e)
            {
                ilogger.LogError("Exception Detail :" + e.InnerException);
            }
            return BadRequest();
        }
        #endregion

    }
}
