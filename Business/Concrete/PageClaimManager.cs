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
    public class PageClaimManager : IPageClaimService
    {
        IPageClaimRepository _pageClaimRepository;
        public async Task Add(PageClaim pageClaim)
        {
            await _pageClaimRepository.Add(pageClaim);
        }

        public async Task Delete(PageClaim pageClaim)
        {
            await _pageClaimRepository.Delete(pageClaim);
        }

        public async Task Update(PageClaim pageClaim)
        {
            await _pageClaimRepository.Update(pageClaim);
        }
    }
}
