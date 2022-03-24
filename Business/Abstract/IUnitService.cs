using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUnitService
    {
        public Task Add(Unit unit);
        public Task Update(Unit unit);
        public Task Delete(Unit unit);
    }
}
