using CQRS_Pattern.Interface;
using CQRS_Pattern.Model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Pattern.Commands
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Customer>
    {
        private readonly IRepository _repository;

        public CreateCustomerCommandHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _repository.AddAsync(request.Customer);
        }
    }
}
