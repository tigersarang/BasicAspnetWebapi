using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer?> GetCustomer(int id);
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer customer);
    }
}