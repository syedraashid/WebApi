using CompanyDetails.DTO;
using CompanyDetails.Models;

namespace CompanyDetails.Services
{
    public interface IRoleService
    {
        public Task<bool> Create_Role(RoleDto role);

        public Task<Role> Disply_Role(int id);

        public Task<bool> DeleteRoleDetails(int id);

        public Task<bool> UpdateRole(int id, RoleDto role);

    }
}
