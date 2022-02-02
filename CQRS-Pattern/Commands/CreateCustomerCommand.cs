using CQRS_Pattern.Model;
using MediatR;

namespace CQRS_Pattern.Commands
{
    public class CreateCustomerCommand : IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}
