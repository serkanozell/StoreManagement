using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGroupService
    {
        public Task Add(Group group);
        public Task Update(Group group);
        public Task Delete(Group group);
    }
}
