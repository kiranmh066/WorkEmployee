using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<EmployeeModel> emp2List;
        public EmployeeService(List<EmployeeModel> employees)
        {
            emp2List = employees;
        }
        public List<EmployeeModel> GetAllEmployee()
        {
            return (emp2List.ToList());
        }

        public bool AddEmployee(EmployeeModel emp)
        {
            if(emp!=null)
            {
                emp2List.Add(emp);
                return true;
            }
            return false;
        }

        public bool DeleteEmployee(int empId)
        {
            if (empId != null)
            {
                emp2List.RemoveAll(e => e.EmpID == empId);
                return true;
            }
            return false;
        }
        public bool UpdateEmployee(EmployeeModel emp)
        {
            var empToUpdate = emp2List.FirstOrDefault(e => e.EmpID == emp.EmpID);
            if (empToUpdate != null)
            {
                empToUpdate.EmpName = emp.EmpName;
                empToUpdate.EmpLocation = emp.EmpLocation;
                return true;
            }
            return false;
        }
    }
}
