using CompanyDetails.DTO;
using CompanyDetails.Models;

namespace CompanyDetails.Services
{
    public interface IDepartmentServices
    {
        public Task<bool> Create_Department(DepartmentDto department);

        public Task<Department> Disply_Department(int id);

        public Task<bool> DeleteDepartmentDetils(int id);

        public Task<bool> UpdateDepartment(int id, DepartmentDto department);

   

    }
}
