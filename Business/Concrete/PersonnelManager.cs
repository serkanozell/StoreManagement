using Business.Abstract;
using Business.Messages;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonnelManager : IPersonnelService
    {
        IPersonnelRepository _personnelRepository;

        public PersonnelManager(IPersonnelRepository personnelRepository)
        {
            _personnelRepository = personnelRepository;
        }

        public async Task<IResult> Add(Personnel personnel)
        {
            await _personnelRepository.Add(personnel);
            return new SuccessResult(Message.Added);
        }

        public async Task<IResult> Delete(Personnel personnel)
        {
            await _personnelRepository.Delete(personnel);
            return new SuccessResult(Message.Deleted);
        }

        public async Task<Personnel> GetByUserName(string userName)
        {
            var result = await _personnelRepository.Get(p => p.UserName == userName);
            return result;
        }

        public List<Role> GetClaims(Personnel personnel)
        {
            return _personnelRepository.GetClaims(personnel);
        }

        public async Task<IResult> Update(Personnel personnel)
        {
            await _personnelRepository.Update(personnel);
            return new SuccessResult(Message.Updated);
        }
    }
}
