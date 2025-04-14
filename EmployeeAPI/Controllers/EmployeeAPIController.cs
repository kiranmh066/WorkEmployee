using EmployeeAPI.Models;
using EmployeeAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAPIController : ControllerBase
    {
        /*private static List<EmployeeModel> emp = new List<EmployeeModel> {
        new EmployeeModel { EmpID = 1, EmpName = "Kiran", EmpLocation = "Bengaluru" }
        };*/


        private readonly IEmployeeService _employeeService;
        public EmployeeAPIController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public List<EmployeeModel> GetAllEmployee()
        {
            //var list = emp.ToList();
            return _employeeService.GetAllEmployee(); ;
        }

        [HttpPost]
        public bool AddEmployee(EmployeeModel employee)
        {
            /*if(employee!=null)
            {
                //new EmployeeModel { EmpID = employee.EmpID, EmpName = employee.EmpName, EmpLocation = employee.EmpLocation };
                emp.Add(employee);
                return true;
            }*/
            return _employeeService.AddEmployee(employee);
        }

        [HttpPut]
        public bool UpdateEmployee(EmployeeModel employee)
        {
            /*if (employee.EmpID != null && emp!=null)
            {
                foreach(var item in emp)
                {
                    if (item.EmpID == employee.EmpID)
                    {
                        item.EmpLocation = employee.EmpLocation;
                        item.EmpName = employee.EmpName;
                    }
                }
                return true;
            }*/
            return _employeeService.UpdateEmployee(employee);
        }

        [HttpDelete]
        public bool DeleteEmployee(int id)
        {
            /*if(id != null)
            {
                emp.RemoveAll(e => e.EmpID == id);
                return true;
            }*/
            return _employeeService.DeleteEmployee(id);
        }

    }
}
