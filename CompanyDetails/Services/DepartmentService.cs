using CompanyDetails.DTO;
using CompanyDetails.Models;
using CompanyDetails.Repository;

namespace CompanyDetails.Services
{
    public class DepartmentService:IDepartmentServices
    {
        public readonly IDepartmentRepository _Repository;
        public DepartmentService(IDepartmentRepository dep)
        {
            _Repository = dep;
            
        }

        public async Task<bool> Create_Department(DepartmentDto employee)
        {
          var output= await _Repository.Create_Department(employee);
            return output > 0? true: false;
        }

       public async Task<bool> DeleteDepartmentDetils(int id)
        {
           var output=await  _Repository.Delete_Department(id);

            return output > 0? true: false;
        }

      public  async Task<Department> Disply_Department(int id)
        {
           var output=await _Repository.Display_Department(id);

            return output; 
        }

       public async Task<bool> UpdateDepartment(int id, DepartmentDto department)
        {
            var output=await _Repository.Update_Department(id, department);

            return output>0?true: false;
        }

    }
}
