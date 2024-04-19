using ASPNetCoreWebApi1.ApplicationLayer.Commands;
using ASPNetCoreWebApi1.ApplicationLayer.DTOs;
using ASPNetCoreWebApi1.InfrastructureLayer.Data;
using MediatR;

namespace ASPNetCoreWebApi1.InfrastructureLayer.Handlers.EmployeeHandler
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, ServiceResponse>
    {
        private readonly AppDbContext appDbContext;

        public DeleteEmployeeHandler(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<ServiceResponse> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await appDbContext.Employees.FindAsync(request.Id);
            if (employee == null)
            {
                return new ServiceResponse(false, "Employee not found");
            }
            appDbContext.Employees.Remove(employee);
            await appDbContext.SaveChangesAsync();
            return new ServiceResponse(true, "Deleted");
        }
    }
}
