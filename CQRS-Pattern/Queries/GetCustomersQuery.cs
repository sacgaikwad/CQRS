using CQRS_Pattern.Model;
using MediatR;
using System.Collections.Generic;

namespace CQRS_Pattern.Queries
{
    public class GetCustomersQuery : IRequest<List<Customer>>
    {
    }
}
