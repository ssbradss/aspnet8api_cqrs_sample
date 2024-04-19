using ASPNetCoreWebApi1.ApplicationLayer.DTOs;
using ASPNetCoreWebApi1.DomainLayer.Entity;
using ASPNetCoreWebApi1.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreWebApi1.InfrastructureLayer.Implementation
{
    public class EmployeeRepo : IEmployee
    {
        private AppDbContext appDbContext;

        public EmployeeRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<ServiceResponse> AddAsync(Employee employee)
        {
            appDbContext.Employees.Add(employee);
            await this.SaveChangesAsync();
            return new ServiceResponse(true, "Added");
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            var employee = await appDbContext.Employees.FindAsync(id);
            if (employee == null)
            {
                return new ServiceResponse(false, "Employee not found");
            }
            appDbContext.Employees.Remove(employee);
            await SaveChangesAsync();
            return new ServiceResponse(true, "Deleted");
        }

        public async Task<List<Employee>> GetAsync() => await appDbContext.Employees.AsNoTracking().ToListAsync();

        public async Task<Employee> GetByIdAsync(int id) => await appDbContext.Employees.FindAsync(id);

        public async Task<ServiceResponse> UpdateAsync(Employee employee)
        {
            appDbContext.Update(employee);
            await SaveChangesAsync();
            return new ServiceResponse(true, "Updated");
        }
        private async Task SaveChangesAsync() => await appDbContext.SaveChangesAsync();
    }
}
