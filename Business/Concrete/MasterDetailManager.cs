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
    public class MasterDetailManager : IMasterDetailService
    {
        IMasterDetailRepository _masterDetailRepository;

        public MasterDetailManager(IMasterDetailRepository masterDetailRepository)
        {
            _masterDetailRepository = masterDetailRepository;
        }

        public async Task Add(MasterDetail masterDetail)
        {
            await _masterDetailRepository.Add(masterDetail);
        }

        public async Task Delete(MasterDetail masterDetail)
        {
            await _masterDetailRepository.Delete(masterDetail);
        }

        public async Task Update(MasterDetail masterDetail)
        {
            await _masterDetailRepository.Update(masterDetail);
        }
    }
}
