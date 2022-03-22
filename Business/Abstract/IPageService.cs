using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPageService
    {
        public Task Add(Page page);
        public Task Update(Page page);
        public Task Delete(Page page);
    }
}
