using CompanyDetails.DTO;
using CompanyDetails.Models;

namespace CompanyDetails.Repository
{
    public interface IDepartmentRepository
    {
        public Task<int> Create_Department(DepartmentDto employee);

        public Task<Department> Display_Department(int id);

        public Task<int> Update_Department(int id, DepartmentDto dep);

        public Task<int > Delete_Department(int id);

        public Task<List<Department>> Filter_Department_Details(DepartmentFilterDto dto);
    }
}
