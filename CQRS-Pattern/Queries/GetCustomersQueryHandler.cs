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
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, List<Customer>>
    {
        private readonly IRepository _repository;

        public GetCustomersQueryHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Customer>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            return _repository.GetAll().Result;
            //return await _repository.GetAll().ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
