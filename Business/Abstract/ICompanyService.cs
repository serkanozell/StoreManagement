using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        public Task Add(Company company);
        public Task Update(Company company);
        public Task Delete(Company company);
    }
}
