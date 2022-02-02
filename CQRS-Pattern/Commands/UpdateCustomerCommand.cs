using CQRS_Pattern.Model;
using MediatR;

namespace CQRS_Pattern.Commands
{
    public class UpdateCustomerCommand : IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}
