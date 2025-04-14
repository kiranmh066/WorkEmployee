using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetAllEmployee();

        bool AddEmployee(EmployeeModel emp);

        bool UpdateEmployee(EmployeeModel emp);

        bool DeleteEmployee(int empId);
    }
}
