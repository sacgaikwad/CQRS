using CQRS_Pattern.Interface;
using CQRS_Pattern.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Pattern.Queries
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Customer>
    {
        private readonly IRepository _repository;

        public GetCustomerByIdQueryHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            return _repository.GetAll().Result.FirstOrDefault(x => x.Id.Equals(request.Id));
        }
    }
}
