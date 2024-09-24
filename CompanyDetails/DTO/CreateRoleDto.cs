using CompanyDetails.Models;

namespace CompanyDetails.DTO
{
    public static class CreateRoleDto
    {
        public static Role create_Role_Dto(this RoleDto role)
        {
            return new Role
            {
                RoleName= role.RoleName,
                Creatingdate=System.DateTime.Now,
                DepartmentId=role.DepartmentId,
            };
        }

    }
}
