using ASPNetCoreWebApi1.ApplicationLayer.Commands;
using ASPNetCoreWebApi1.ApplicationLayer.DTOs;
using ASPNetCoreWebApi1.DomainLayer.Entity;
using ASPNetCoreWebApi1.InfrastructureLayer.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreWebApi1.InfrastructureLayer.Handlers.EmployeeHandler
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, ServiceResponse>
    {
        private readonly AppDbContext appDbContext;

        public UpdateEmployeeHandler(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<ServiceResponse> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            appDbContext.Update(request.employee);
            await appDbContext.SaveChangesAsync();
            return new ServiceResponse(true, "Updated");
        }
    }
}
