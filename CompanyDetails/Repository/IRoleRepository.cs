using CompanyDetails.DTO;
using CompanyDetails.Models;

namespace CompanyDetails.Repository
{
    public interface IRoleRepository
    {

        public Task<int> Insert_RoleDetails(RoleDto employee);

        public Task<Role> Display_RoleDetails(int id);

        public Task<int> Update_RoleDetails(int id, RoleDto dep);

        public Task<int> Delete_RoleDetails(int id);

    }
}
