using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        public Task Add(Customer customer);
        public Task Update(Customer customer);
        public Task Delete(Customer customer);
    }
}
