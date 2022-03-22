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
    public class CommunicationManager : ICommunicationService
    {
        ICommunicationRepository _communicationRepository;

        public CommunicationManager(ICommunicationRepository communicationRepository)
        {
            _communicationRepository = communicationRepository;
        }

        public async Task Add(Communication communication)
        {
            await _communicationRepository.Add(communication);
        }

        public async Task Delete(Communication communication)
        {
            await _communicationRepository.Delete(communication);
        }

        public async Task Update(Communication communication)
        {
            await _communicationRepository.Update(communication);
        }
    }
}
