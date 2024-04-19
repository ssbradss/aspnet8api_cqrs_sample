using ASPNetCoreWebApi1.ApplicationLayer.Queries.EmployeeQuery;
using ASPNetCoreWebApi1.DomainLayer.Entity;
using ASPNetCoreWebApi1.InfrastructureLayer.Data;
using MediatR;

namespace ASPNetCoreWebApi1.InfrastructureLayer.Handlers.EmployeeHandler
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly AppDbContext appDbContext;

        public GetEmployeeByIdHandler(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await appDbContext.Employees.FindAsync(request.Id);
        }
    }
}
