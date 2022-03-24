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
    public class StatusManager : IStatusService
    {
        IStatusRepository _statusRepository;

        public StatusManager(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        public async Task Add(Status status)
        {
            await _statusRepository.Add(status);
        }

        public async Task Delete(Status status)
        {
            await _statusRepository.Delete(status);
        }

        public async Task Update(Status status)
        {
            await _statusRepository.Update(status);
        }
    }
}
