using CompanyDetails.DTO;
using CompanyDetails.Repository;
using CompanyDetails.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentServices _services;

        public DepartmentController(IDepartmentServices dep)
        {
            _services = dep;
        }


        [HttpPost("createDepartment")]

        public async Task<IActionResult> create_Department([FromBody] DepartmentDto dep)
        {
            var output = await _services.Create_Department(dep);
            return output ? Ok(dep) : BadRequest();
        }


        [HttpGet("GetEmployeesbyDepartmentId/{id}")]
        public async Task<IActionResult> display_Department(int id)
        {
            var result = await _services.Disply_Department(id);

            return result == null ? BadRequest() : Ok(result);
        }


        [HttpPost("Updatedepartmentdetails/{id}")]

        public async Task<IActionResult> update_details([FromRoute] int id, [FromBody] DepartmentDto dto)
        {
            var result = await _services.UpdateDepartment(id, dto);

            return result ? Ok("update sucessfully") : BadRequest();
        }



        [HttpDelete("DeleteDepartmentByDepartmentId/{id}")]

        public async Task<IActionResult> DeleteDepartmentDetails(int id) { 
           var result= await _services.DeleteDepartmentDetils(id);
            return result? Ok("deletedSucessfully"):BadRequest();
        }

    }
}
