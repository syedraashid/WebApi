using CompanyDetails.Models;

namespace CompanyDetails.DTO
{
    public static class CreateDepartmentDto
    {
        public static Department create_department_Dto(this DepartmentDto dep)
        {
            return new Department
            {
                DepartmentName= dep.DepartmentName,
                Location= dep.Location,
            };
        }

    }
}
