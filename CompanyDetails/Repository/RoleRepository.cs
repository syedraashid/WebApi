using CompanyDetails.Data;
using CompanyDetails.DTO;
using CompanyDetails.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace CompanyDetails.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;
        public RoleRepository(ApplicationDbContext _Dbcontext)
        {
            _context = _Dbcontext;
        }

        public async Task<int> Delete_RoleDetails(int id)
        {
            await _context.Roles.FindAsync(id);
            var result= await _context.SaveChangesAsync();
            return result;
        }

        public async Task<Role> Display_RoleDetails(int id)
        {
          var result=await  _context.Roles.Include(x =>x.Employees).FirstOrDefaultAsync(x=>x.RoleId==id);

            return result;
        }

        public async Task<int> Insert_RoleDetails(RoleDto role)
        {
          var output=  CreateRoleDto.create_Role_Dto(role);

              _context.Roles.Add(output);

            var result=await  _context.SaveChangesAsync();

            return result;
        }

        public async Task<int> Update_RoleDetails(int id,RoleDto role)
        {
            var Id =await _context.Roles.FindAsync(id);

            if (Id != null)
            {
                Id.RoleName = role.RoleName;
            }
            var output =await _context.SaveChangesAsync();
            return output;
        }
    }
}
