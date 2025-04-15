using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmpID { get; set; }

        public string EmpName { get; set; }

        public string EmpLocation { get; set; }
    }
}
