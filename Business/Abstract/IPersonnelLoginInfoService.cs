using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonnelLoginInfoService
    {
        public Task Add(PersonnelLoginInfo personnelLoginInfo);
        public Task Update(PersonnelLoginInfo personnelLoginInfo);
        public Task Delete(PersonnelLoginInfo personnelLoginInfo);
    }
}
