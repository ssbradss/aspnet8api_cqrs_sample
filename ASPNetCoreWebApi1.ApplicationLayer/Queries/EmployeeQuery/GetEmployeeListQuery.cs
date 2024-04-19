using ASPNetCoreWebApi1.DomainLayer.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNetCoreWebApi1.ApplicationLayer.Queries.EmployeeQuery
{
    public class GetEmployeeListQuery : IRequest<List<Employee>>
    {
    }
}
