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
    public class CommTypeManager : ICommTypeService
    {
        ICommTypeRepository _commTypeRepository;

        public CommTypeManager(ICommTypeRepository commTypeRepository)
        {
            _commTypeRepository = commTypeRepository;
        }

        public async Task Add(CommType commType)
        {
            await _commTypeRepository.Add(commType);
        }

        public async Task Delete(CommType commType)
        {
            await _commTypeRepository.Delete(commType);
        }

        public async Task Update(CommType commType)
        {
            await _commTypeRepository.Update(commType);
        }
    }
}
