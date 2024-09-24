using CompanyDetails.DTO;
using CompanyDetails.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyDetails.Services
{
    public interface IEmployeeService
    {
        public Task<bool> Create_Employee(EmployeeDto employee);

        public Task<Employee> Disply_Employee(int id);

        public Task<bool> DeleteEmployeeDetils(int id);

        public Task<bool> UpdateEmployee(int id , EmployeeDto employee);

    }
}
