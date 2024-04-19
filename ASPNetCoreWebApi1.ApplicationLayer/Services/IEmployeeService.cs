using ASPNetCoreWebApi1.ApplicationLayer.DTOs;
using ASPNetCoreWebApi1.DomainLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNetCoreWebApi1.ApplicationLayer.Services
{
    public interface IEmployeeService
    {
        Task<ServiceResponse> AddAsync(Employee employee);
        Task<ServiceResponse> UpdateAsync(Employee employee);
        Task<ServiceResponse> DeleteAsync(int id);
        Task<List<Employee>> GetAsync();
        Task<Employee> GetByIdAsync(int id);
    }
}
