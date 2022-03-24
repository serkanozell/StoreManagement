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
    public class PriceManager : IPriceService
    {
        IPriceRepository _priceRepository;

        public PriceManager(IPriceRepository priceRepository)
        {
            _priceRepository = priceRepository;
        }

        public async Task Add(Price price)
        {
            await _priceRepository.Add(price);
        }

        public async Task Delete(Price price)
        {
            await _priceRepository.Delete(price);
        }

        public async Task Update(Price price)
        {
            await _priceRepository.Update(price);
        }
    }
}
