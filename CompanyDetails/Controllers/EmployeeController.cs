using CompanyDetails.DTO;
using CompanyDetails.Models;
using CompanyDetails.Repository;
using CompanyDetails.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace CompanyDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _Service;

        public EmployeeController(IEmployeeService repo)
        {
            _Service = repo;
        }

        [HttpPost("creaeteemployee")]

        public async Task<IActionResult> create_Employee([FromBody]EmployeeDto employee) { 

            var result=await _Service.Create_Employee(employee);

            return result ? Ok("sucessfully added") : BadRequest();
           
        }

        [HttpGet("GetEmployeeDetailsById/{id}")]

        public async Task<IActionResult> GetEmployeeDetails(int id)
        {
            var output = await _Service.Disply_Employee(id);

            return output!=null ? Ok(output) : BadRequest();    
        }

        [HttpDelete("DeleteEmployeeDetailsById/{id}")]
        public async Task<IActionResult> DeleteEmployeeDetails(int id)
        {
            var output=await _Service.DeleteEmployeeDetils(id);

            return output ?Ok("DetailsDeletedSucessfully") : BadRequest();

        }

        [HttpPost("UpdateEmployeeDetailsById/{id}")]

        public async Task<IActionResult> UpdateEmplyeeDetails(int id, [FromBody]EmployeeDto employee)
        {
            var output=await _Service.UpdateEmployee(id, employee);

            return output ? Ok(employee) : BadRequest();

        }



    }

    
}
