using CompanyDetails.DTO;
using CompanyDetails.Models;

namespace CompanyDetails.Repository
{
    public interface IEmployeeRepository
    {
       public Task<int> Create_Employee(EmployeeDto employee);

        public Task<Employee> Display_Employee(int id);

        public Task<int> Delete_Employee(int id);

        public Task<int> UpdteEmployee(int Id,EmployeeDto dep);




    }
}
