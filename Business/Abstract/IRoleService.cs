using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoleService
    {
        public Task Add(Role role);
        public Task Update(Role role);
        public Task Delete(Role role);
    }
}
