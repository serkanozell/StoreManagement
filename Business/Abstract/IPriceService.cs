using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPriceService
    {
        public Task Add(Price price);
        public Task Update(Price price);
        public Task Delete(Price price);
    }
}
