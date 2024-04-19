using ASPNetCoreWebApi1.ApplicationLayer.Commands;
using ASPNetCoreWebApi1.ApplicationLayer.DTOs;
using ASPNetCoreWebApi1.InfrastructureLayer.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreWebApi1.InfrastructureLayer.Handlers.EmployeeHandler
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, ServiceResponse>
    {
        private readonly AppDbContext appDbContext;

        public CreateEmployeeHandler(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<ServiceResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var check = await appDbContext.Employees.FirstOrDefaultAsync(_ => _.Name.ToLower() == request.employee.Name.ToLower());
            if(check != null) {
                return new ServiceResponse(false, "Employee already exist");
            }

            appDbContext.Employees.Add(request.employee);
            await appDbContext.SaveChangesAsync(cancellationToken); 
            return new ServiceResponse(true, "Added");
        }
    }
}
