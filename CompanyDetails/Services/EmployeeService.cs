using CompanyDetails.DTO;
using CompanyDetails.Models;
using CompanyDetails.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CompanyDetails.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository IRep)
        {
            _employeeRepository = IRep;
        }

        public async Task<bool> Create_Employee(EmployeeDto employee)
        {
           var output =await  _employeeRepository.Create_Employee(employee);

            return output > 0 ? true:false;

        }

        public async Task<bool> DeleteEmployeeDetils(int id)
        {
           var output= await _employeeRepository.Delete_Employee(id);
            return output >0?true:false;
        }

        public async Task<Employee> Disply_Employee(int id)
        {
            var output =await  _employeeRepository.Display_Employee(id);

            return output;
        }

        public async Task<bool> UpdateEmployee(int id, EmployeeDto employee)
        {
            var result=await _employeeRepository.UpdteEmployee(id, employee);

            return result>0? true:false;
        }
    }
}
