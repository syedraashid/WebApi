using CompanyDetails.Data;
using CompanyDetails.DTO;
using CompanyDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyDetails.Repository
{
    public class DepartmentRepository:IDepartmentRepository
    {
        private readonly ApplicationDbContext _DbCOntext;


        public DepartmentRepository(ApplicationDbContext db)
        {
            _DbCOntext = db;
        }


        public async Task<int> Create_Department(DepartmentDto dep)
        {
            var result = CreateDepartmentDto.create_department_Dto(dep);

            await _DbCOntext.Departments.AddAsync(result);
            var output = await _DbCOntext.SaveChangesAsync();
            return (output);
        }

        public async Task<int> Delete_Department(int id)
        {
           var output=await _DbCOntext.Departments.Include(x => x.Roles).FirstOrDefaultAsync(x => x.DepartmentId == id);
            _DbCOntext.Departments.Remove(output);
           var result=await _DbCOntext.SaveChangesAsync();
            return (result);
        }

        public async Task<Department> Display_Department(int id)
        {
            var result = await _DbCOntext.Departments.Include(d => d.Roles).FirstOrDefaultAsync(x => x.DepartmentId == id);

            return result;
        }

        public async Task<List<Department>> Filter_Department_Details(DepartmentFilterDto dto)
        { 
            List<Department> ans = new List<Department>();
            if (dto.Count != null)
            {
              foreach (var d in _DbCOntext.Departments)
                {
                    if( d.Roles.Count() == dto.Count)
                    {
                       ans.Add(d);
                    }
                }
               
               return ans;
            }

            if (dto.location != null) { 

                foreach(var d in _DbCOntext.Departments)
                {
                    if (d.Location == dto.location)
                    {
                        ans.Add(d);
                    }
                }
                return ans;
            }

            return ans;
          
        }

        public async Task<int> Update_Department(int id, DepartmentDto d)
        {
            var res = _DbCOntext.Departments.Find(id);

            if (res != null)
            {
                res.DepartmentName = d.DepartmentName;
                res.Location = d.Location;

            }
            var output = await _DbCOntext.SaveChangesAsync();

            return output;
        }

    }
}
