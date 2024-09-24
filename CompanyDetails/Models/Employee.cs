using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyDetails.Models
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public int  RoleId { get; set; }
        public Role Role { get; set; }

    }
}
