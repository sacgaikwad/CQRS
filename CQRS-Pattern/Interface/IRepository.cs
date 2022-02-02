using CQRS_Pattern.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Pattern.Interface
{
    public interface IRepository
    {
        Task<List<Customer>> GetAll();

        Task<Customer> AddAsync(Customer entity);

        Task<Customer> UpdateAsync(Customer entity);
    }
}
