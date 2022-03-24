using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRolePersonnelService
    {
        public Task Add(RolePersonnel rolePersonnel);
        public Task Update(RolePersonnel rolePersonnel);
        public Task Delete(RolePersonnel rolePersonnel);
    }
}
