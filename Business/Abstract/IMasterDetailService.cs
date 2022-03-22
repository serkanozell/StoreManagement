using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMasterDetailService
    {
        public Task Add(MasterDetail masterDetail);
        public Task Update(MasterDetail masterDetail);
        public Task Delete(MasterDetail masterDetail);
    }
}
