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
    public class UnitManager : IUnitService
    {
        IUnitRepository _unitRepository;

        public UnitManager(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        public async Task Add(Unit unit)
        {
            await _unitRepository.Add(unit);
        }

        public async Task Delete(Unit unit)
        {
            await _unitRepository.Delete(unit);
        }

        public async Task Update(Unit unit)
        {
            await _unitRepository.Update(unit);
        }
    }
}
