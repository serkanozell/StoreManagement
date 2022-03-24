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
    public class PersonnelTeamManager : IPersonnelTeamService
    {
        IPersonnelTeamRepository _personnelTeamRepository;
        public async Task Add(PersonnelTeam personnelTeam)
        {
            await _personnelTeamRepository.Add(personnelTeam);
        }

        public async Task Delete(PersonnelTeam personnelTeam)
        {
            await _personnelTeamRepository.Delete(personnelTeam);
        }

        public async Task Update(PersonnelTeam personnelTeam)
        {
            await _personnelTeamRepository.Update(personnelTeam);
        }
    }
}
