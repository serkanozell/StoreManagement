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
    public class ClaimsManager : IClaimsService
    {
        IClaimsRepository _claimsRepository;

        public ClaimsManager(IClaimsRepository claimsRepository)
        {
            _claimsRepository = claimsRepository;
        }

        public async Task Add(Claims claims)
        {
            await _claimsRepository.Add(claims);
        }

        public async Task Delete(Claims claims)
        {
            await _claimsRepository.Delete(claims);
        }

        public async Task Update(Claims claims)
        {
            await _claimsRepository.Update(claims);
        }
    }
}
