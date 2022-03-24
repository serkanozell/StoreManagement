using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPageClaimService
    {
        public Task Add(PageClaim pageClaim);
        public Task Update(PageClaim pageClaim);
        public Task Delete(PageClaim pageClaim);
    }
}
