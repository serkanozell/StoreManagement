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
    public class CurrencyManager : ICurrencyService
    {
        ICurrencyRepository _currencyRepository;

        public CurrencyManager(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task Add(Currency currency)
        {
            await _currencyRepository.Add(currency);
        }

        public async Task Delete(Currency currency)
        {
            await _currencyRepository.Delete(currency);
        }

        public async Task Update(Currency currency)
        {
            await _currencyRepository.Update(currency);
        }
    }
}
