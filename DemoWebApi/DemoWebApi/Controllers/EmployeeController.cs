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
            throw new NotImplementedException();
          // return employee.GetEmployeeDetails();       
        }

        [HttpPost("Post")]
        public IActionResult Post(Employee employeeData)
        {
            employee.AddEmployeeDetails(employeeData);
            // Assuming employeeData.Id is now set after saving
            return CreatedAtAction(nameof(Get), new { id = employeeData.Id }, employeeData);
            // return Created();
        }


        [HttpGet("/Employee/GetById")]
        public IActionResult Search(int id)
        {
            Employee e=  employee.SearchEmployee(id);

            if( e == null)
            {
                return NotFound($"Employee with {id} doesn't exists");
            }
            var message = new {message= $"The employee with id {id}" , e};
            return Ok( message);
        }
    }
}
