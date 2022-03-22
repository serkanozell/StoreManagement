using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICurrencyService
    {
        public Task Add(Currency currency);
        public Task Update(Currency currency);
        public Task Delete(Currency currency);
    }
}
