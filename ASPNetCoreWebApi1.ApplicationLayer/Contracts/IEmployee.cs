using ASPNetCoreWebApi1.DomainLayer.Entity;

namespace ASPNetCoreWebApi1.ApplicationLayer.DTOs
{
    public interface IEmployee { 
        Task<ServiceResponse> AddAsync(Employee employee);
        Task<ServiceResponse> UpdateAsync(Employee employee);
        Task<ServiceResponse> DeleteAsync(int id);
        Task<List<Employee>> GetAsync();
        Task<Employee> GetByIdAsync(int id);
    }
}
