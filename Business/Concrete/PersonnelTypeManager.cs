using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonnelTypeManager : IPersonnelTypeService
    {
        IPersonnelTypeRepository _personnelTypeRepository;
        public async Task Add(PersonnelType personnelType)
        {
            await _personnelTypeRepository.Add(personnelType);
        }

        public async Task Delete(PersonnelType personnelType)
        {
            await _personnelTypeRepository.Delete(personnelType);
        }

        public async Task Update(PersonnelType personnelType)
        {
            await _personnelTypeRepository.Update(personnelType);
        }
    }
}
