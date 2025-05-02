using DemoWebApi.Model;
using DemoWebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmplolyeeBuisenesslogic employee;

        public EmployeeController(IEmplolyeeBuisenesslogic employee)
        {
            this.employee = employee;
        }

        [HttpGet("Get")]
        
        public List<Employee> Get()
        {
           return employee.GetEmployeeDetails();       
        }

        [HttpPost("Post")]
        public void Post(Employee employeeData)
        {
            employee.AddEmployeeDetails(employeeData);
        }
    }
}
