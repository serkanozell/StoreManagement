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
    public class GroupManager : IGroupService
    {
        IGroupRepository _groupRepository;

        public GroupManager(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task Add(Group group)
        {
            await _groupRepository.Add(group);
        }

        public async Task Delete(Group group)
        {
            await _groupRepository.Delete(group);
        }

        public async Task Update(Group group)
        {
            await _groupRepository.Update(group);
        }
    }
}
