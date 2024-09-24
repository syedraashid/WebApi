using CompanyDetails.DTO;
using CompanyDetails.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService role)
        {
            _roleService = role;
        }

        [HttpPost("createRole")]

        public async Task<IActionResult> create_Department([FromBody] RoleDto role)
        {
            var output = await _roleService.Create_Role(role);
            return output ? Ok(role) : BadRequest();
        }


        [HttpGet("GetRoleByRoleId/{id}")]
        public async Task<IActionResult> display_Department(int id)
        {
            var result = await _roleService.Disply_Role(id);

            return result == null ? BadRequest() : Ok(result);
        }


        [HttpPost("UpdateRoleDetails/{id}")]

        public async Task<IActionResult> update_details([FromRoute] int id, [FromBody] RoleDto dto)
        {
            var result = await _roleService.UpdateRole(id, dto);

            return result ? Ok("update sucessfully") : BadRequest();
        }



        [HttpDelete("DeleteRoleByRoleId/{id}")]

        public async Task<IActionResult> DeleteDepartmentDetails(int id)
        {
            var result = await _roleService.DeleteRoleDetails(id);

            return result ? Ok("deletedSucessfully") : BadRequest();

        }
    }
}
