using CQRS_Pattern.Model;
using MediatR;
using System;

namespace CQRS_Pattern.Queries
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public Guid Id { get; set; }
    }
}
