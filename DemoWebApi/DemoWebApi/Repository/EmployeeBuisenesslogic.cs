using DemoWebApi.Model;

namespace DemoWebApi.Repository
{
    public class EmployeeBuisenesslogic : IEmplolyeeBuisenesslogic
    {

        List<Employee> employees = new List<Employee>() { new Employee() { Id=1, Name="Mohit",Gender="M",Salary=1000000} };
        public List<Employee> GetEmployeeDetails()
        {
            return employees;
        }

        public void AddEmployeeDetails(Employee employee)
        { 
         employees.Add(employee);
        }
       
        public Employee SearchEmployee(int id)
        {
          return  employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
