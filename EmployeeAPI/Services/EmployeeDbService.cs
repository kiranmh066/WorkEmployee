using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public class EmployeeDbService : IEmployeeService
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeDbService(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public async Task AddEmployee(EmployeeModel emp)
        {
            if(emp!=null)
            {
                _employeeDbContext.Add(emp);
                await _employeeDbContext.SaveChanges();
            }
            //return false;
        }

        public bool DeleteEmployee(int empId)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(EmployeeModel emp)
        {
            throw new NotImplementedException();
        }
    }
}
