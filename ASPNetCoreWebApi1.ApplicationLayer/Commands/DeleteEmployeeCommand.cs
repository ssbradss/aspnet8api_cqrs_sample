using ASPNetCoreWebApi1.ApplicationLayer.DTOs;
using ASPNetCoreWebApi1.DomainLayer.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNetCoreWebApi1.ApplicationLayer.Commands
{
    public class DeleteEmployeeCommand : IRequest<ServiceResponse>
    {
        public int Id { get; set; }
    }
}
