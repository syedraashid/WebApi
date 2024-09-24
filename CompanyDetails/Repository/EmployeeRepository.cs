using CompanyDetails.Data;
using CompanyDetails.DTO;
using CompanyDetails.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Frozen;

namespace CompanyDetails.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _DbCOntext;


        public EmployeeRepository(ApplicationDbContext db)
        {
            _DbCOntext = db;
        }

        public async Task<int> Create_Employee(EmployeeDto employee)
        {
            var result = CreateEmployeeDto.createEmployee(employee);

          await  _DbCOntext.Employees.AddAsync(result);
           var output= await _DbCOntext.SaveChangesAsync();
            return (output);

            
        }

        public async  Task<int> Delete_Employee(int id)
        {
           var result=await _DbCOntext.Employees.FindAsync(id);
            _DbCOntext.Employees.Remove(result);
           var output=await _DbCOntext.SaveChangesAsync();

            return output;
        }

        public async Task<Employee> Display_Employee(int id)
        {
           var result=await _DbCOntext.Employees.FindAsync(id);

            return result;
        }

        public async Task<int> UpdteEmployee(int Id,EmployeeDto dto)
        {
            var result = await _DbCOntext.Employees.FindAsync(Id);

            if (result != null)
            {
                result.EmployeeName = dto.EmployeeName;
     
                result.Age = dto.Age;
                result.Salary = dto.Salary;
               
            }

            var output = await _DbCOntext.SaveChangesAsync();

            return output;
             
        }
    }
}
