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
    public class ActionStatusManager : IActionStatusService
    {
        IActionStatusRepository _actionStatusRepository;

        public ActionStatusManager(IActionStatusRepository actionStatusRepository)
        {
            _actionStatusRepository = actionStatusRepository;
        }

        public async Task Add(ActionStatus actionStatus)
        {
            await _actionStatusRepository.Add(actionStatus);
        }

        public async Task Delete(ActionStatus actionStatus)
        {
            await _actionStatusRepository.Add(actionStatus);
        }

        public async Task Update(ActionStatus actionStatus)
        {
            await _actionStatusRepository.Add(actionStatus);
        }
    }
}
