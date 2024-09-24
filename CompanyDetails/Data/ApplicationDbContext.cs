using CompanyDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyDetails.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)


        {

            modelBuilder.Entity<Employee>()
           .HasKey(ds => new { ds.RoleId});

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Roles)
                .WithOne(r => r.Department)
                .HasForeignKey(r => r.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict); // Ensure roles are deleted when department is deleted

            modelBuilder.Entity<Role>()
                .HasMany(r => r.Employees)
                .WithOne(e => e.Role)
                .HasForeignKey(e => e.RoleId)
                .OnDelete(DeleteBehavior.Restrict); // Ensure employees are deleted when role is deleted
        }



    }
}
