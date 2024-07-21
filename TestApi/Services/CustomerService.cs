using Microsoft.EntityFrameworkCore;
using TestApi.Data;
using TestApi.Models;
using TestApi.Repositories;

namespace TestApi.Services
{
    public class CustomerService : ICustomerRepository
    {
        private readonly DataContext _dataContext;

        public CustomerService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public async Task<Customer> AddCustomer(Customer customer)
        {
            await _dataContext.AddAsync(customer);
            await _dataContext.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer?> GetCustomer(int id)
        {
            return await _dataContext.Customers.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _dataContext.Customers.ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            _dataContext.Customers.Attach(customer);
            _dataContext.Entry(customer).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();
            return customer;
        }
    }
}