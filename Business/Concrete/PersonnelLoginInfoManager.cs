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
    public class PersonnelLoginInfoManager : IPersonnelLoginInfoService
    {
        IPersonnelLoginInfoRepository _personnelLoginInfoRepository;

        public PersonnelLoginInfoManager(IPersonnelLoginInfoRepository personnelLoginInfoRepository)
        {
            _personnelLoginInfoRepository = personnelLoginInfoRepository;
        }

        public async Task Add(PersonnelLoginInfo personnelLoginInfo)
        {
            await _personnelLoginInfoRepository.Add(personnelLoginInfo);
        }

        public async Task Delete(PersonnelLoginInfo personnelLoginInfo)
        {
            await _personnelLoginInfoRepository.Delete(personnelLoginInfo);
        }

        public async Task Update(PersonnelLoginInfo personnelLoginInfo)
        {
            await _personnelLoginInfoRepository.Update(personnelLoginInfo);
        }
    }
}
