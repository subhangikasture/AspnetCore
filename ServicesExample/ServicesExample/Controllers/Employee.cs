using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesExample.Services;

namespace ServicesExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee : ControllerBase
    {
        private readonly IEmployeeDetails _empDetails;
        public Employee( IEmployeeDetails employeeDetails)
        {
            _empDetails = employeeDetails;
        }

        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            return Ok(_empDetails.GetName());
        }

    }
}
