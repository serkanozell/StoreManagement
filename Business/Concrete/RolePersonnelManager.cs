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
    public class RolePersonnelManager : IRolePersonnelService
    {
        IRolePersonnelRepository _rolePersonnelRepository;
        public async Task Add(RolePersonnel rolePersonnel)
        {
            await _rolePersonnelRepository.Add(rolePersonnel);
        }

        public async Task Delete(RolePersonnel rolePersonnel)
        {
            await _rolePersonnelRepository.Delete(rolePersonnel);
        }

        public async Task Update(RolePersonnel rolePersonnel)
        {
            await _rolePersonnelRepository.Update(rolePersonnel);
        }
    }
}
