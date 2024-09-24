using CompanyDetails.Models;

namespace CompanyDetails.DTO
{
    public static class CreateEmployeeDto
    {
        public static Employee createEmployee(this EmployeeDto employee) {

            return new Employee
            {
                EmployeeName = employee.EmployeeName,
                Age = employee.Age,
                RoleId=employee.RoleId,
                Salary= employee.Salary,
            };
        }
    }
}
