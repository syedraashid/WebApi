using System.ComponentModel.DataAnnotations;

namespace CompanyDetails.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? Location { get; set; }
        // Navigation property
        public ICollection<Role> Roles { get; set; }

    }
}
