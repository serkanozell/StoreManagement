using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStatusService
    {
        public Task Add(Status status);
        public Task Update(Status status);
        public Task Delete(Status status);
    }
}
