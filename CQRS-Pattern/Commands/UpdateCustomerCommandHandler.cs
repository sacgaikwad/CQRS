using CQRS_Pattern.Interface;
using CQRS_Pattern.Model;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Pattern.Commands
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Customer>
    {
        private readonly IRepository _repository;
        public UpdateCustomerCommandHandler(IRepository repository)
        {
            _repository = repository;
        }
        public Task<Customer> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            return _repository.UpdateAsync(request.Customer);
        }
    }
}
