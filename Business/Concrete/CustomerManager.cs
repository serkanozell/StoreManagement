using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task Add(Customer customer)
        {
            await _customerRepository.Add(customer);
        }

        public async Task Delete(Customer customer)
        {
            await _customerRepository.Delete(customer);
        }

        public async Task Update(Customer customer)
        {
            await _customerRepository.Update(customer);
        }
    }
}
