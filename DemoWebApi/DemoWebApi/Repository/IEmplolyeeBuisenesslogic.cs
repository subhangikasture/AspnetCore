using DemoWebApi.Model;

namespace DemoWebApi.Repository
{
    public interface IEmplolyeeBuisenesslogic
    {
        public List<Employee> GetEmployeeDetails();

        public void AddEmployeeDetails(Employee employee);

        public Employee SearchEmployee(int id);
    }
}
