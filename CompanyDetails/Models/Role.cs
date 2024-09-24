using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyDetails.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public DateTime  Creatingdate { get; set; }
        
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

       
        public List<Employee> Employees { get; set; }

       
    }
}
