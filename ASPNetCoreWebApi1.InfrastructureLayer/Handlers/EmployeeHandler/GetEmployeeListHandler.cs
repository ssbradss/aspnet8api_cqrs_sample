using ASPNetCoreWebApi1.ApplicationLayer.Queries.EmployeeQuery;
using ASPNetCoreWebApi1.DomainLayer.Entity;
using ASPNetCoreWebApi1.InfrastructureLayer.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreWebApi1.InfrastructureLayer.Handlers.EmployeeHandler
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        private readonly AppDbContext appDbContext;

        public GetEmployeeListHandler(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await appDbContext.Employees.AsNoTracking().ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
