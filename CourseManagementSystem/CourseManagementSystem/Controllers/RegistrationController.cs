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
    public class RegistrationController : ControllerBase
    {
        private IRegistrationService courseservice;
        private ILogger<CourseController> ilogger;
        public RegistrationController(IRegistrationService _customerservice, ILogger<CourseController> _ilogger)
        {
            ilogger = _ilogger;
            ilogger.LogInformation("Course class called");
            courseservice = _customerservice;
        }

        #region All Registration
        [HttpGet]
        [Route("[action]")]
        public ActionResult AllRegistration()
        {
            try
            {
                ilogger.LogInformation("Course Endpoint start");
                var cust = courseservice.AllRegisteredStudent();
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


        #region  New Registration
        [HttpPost]
        [Route("[action]")]
        public ActionResult NewRegistration(Registration reg)
        {
            try
            {
                ilogger.LogInformation("Course Endpoint start");
                var check = courseservice.Registration(reg);
                if (check == true)
                {
                    return Ok("Registration is done");
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




        #region DELETE Reagistration
        [HttpDelete]
        [Route("[action]/id")]
        public ActionResult Unregistered(int id)
        {
            try
            {
                ilogger.LogInformation("Course Endpoint start");
                var check= courseservice.DeleteRegistraion(id);
                if (check == true)
                {
                    return Ok("Unregistered from course");
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
