using CQRS_Pattern.Interface;
using CQRS_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS_Pattern.Repository
{
    public class MongoRepository : IRepository
    {
        public MongoRepository()
        {

        }
        public Task<Customer> AddAsync(Customer entity)
        {
            Customer customer = new Customer
            {
                Age = 2,
                Birthday = DateTime.Now,
                FirstName = "John",
                Id = Guid.NewGuid(),
                LastName = "Doe",
                Phone = "9898908767"

            };

            return Task.FromResult<Customer>(customer);
        }

        public Task<List<Customer>> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            Customer customer = new Customer
            {
                Age = 2,
                Birthday = DateTime.Now,
                FirstName = "John",
                Id = Guid.NewGuid(),
                LastName = "Doe",
                Phone = "9898908767"

            };

            customers.Add(customer);

            return Task.FromResult(customers);
        }

        public Task<Customer> UpdateAsync(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
