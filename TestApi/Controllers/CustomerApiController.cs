using Microsoft.AspNetCore.Mvc;
using TestApi.Models;
using TestApi.Repositories;

namespace TestApi.Controllers
{
    public class CustomerApiController : BaseApiController
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerApiController(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetCustomersAsync() {
            return Ok(await _customerRepository.GetCustomers());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerAsync(int id){
            return Ok( await _customerRepository.GetCustomer(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomerAsync(Customer customer) {
            return Ok(await _customerRepository.AddCustomer(customer));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomerAsync(Customer customer) {
            return Ok(await _customerRepository.UpdateCustomer(customer));
        }
    }
}