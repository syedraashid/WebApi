using CompanyDetails.DTO;
using CompanyDetails.Models;
using CompanyDetails.Repository;

namespace CompanyDetails.Services
{
    public class RoleService:IRoleService
    {
        private readonly IRoleRepository _roleRepository;    
        public RoleService(IRoleRepository rep)
        {
            _roleRepository = rep;    
        }

        public async Task<bool> Create_Role(RoleDto role)
        {
           var result =await _roleRepository.Insert_RoleDetails(role);

            return result>0? true:false;
        }

        public async Task<bool> DeleteRoleDetails(int id)
        {
            var result= await _roleRepository.Delete_RoleDetails(id);

            return result>0? true:false;
        }

        public async Task<Role> Disply_Role(int id)
        {
           var result=await _roleRepository.Display_RoleDetails(id);

            return result;
        }

        public async Task<bool> UpdateRole(int id, RoleDto role)
        {
           var result=await _roleRepository.Update_RoleDetails(id, role);

            return result>0? true:false;
        }
    }
}
