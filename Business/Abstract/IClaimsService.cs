using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IClaimsService
    {
        public Task Add(Claims claims);
        public Task Update(Claims claims);
        public Task Delete(Claims claims);
    }
}
