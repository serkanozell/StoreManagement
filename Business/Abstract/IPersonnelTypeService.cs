using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonnelTypeService
    {
        public Task Add(PersonnelType personnelType);
        public Task Update(PersonnelType personnelType);
        public Task Delete(PersonnelType personnelType);
    }
}
