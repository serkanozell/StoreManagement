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
    public class RoleManager : IRoleService
    {
        IRoleRepository _roleRepository;
        public async Task Add(Role role)
        {
            await _roleRepository.Add(role);
        }

        public async Task Delete(Role role)
        {
            await _roleRepository.Delete(role);
        }

        public async Task Update(Role role)
        {
            await _roleRepository.Update(role);
        }
    }
}
