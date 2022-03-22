using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommunicationService
    {
        public Task Add(Communication communication);
        public Task Update(Communication communication);
        public Task Delete(Communication communication);
    }
}
