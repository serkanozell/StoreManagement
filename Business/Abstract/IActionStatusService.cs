using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    interface IActionStatusService
    {
        public Task Add(ActionStatus actionStatus);
        public Task Update(ActionStatus actionStatus);
        public Task Delete(ActionStatus actionStatus);
    }
}
