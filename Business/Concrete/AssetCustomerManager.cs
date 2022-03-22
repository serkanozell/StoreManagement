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
    public class AssetCustomerManager : IAssetCustomerService
    {
        IAssetCustomerRepository _assetCustomerRepository;

        public AssetCustomerManager(IAssetCustomerRepository assetCustomerRepository)
        {
            _assetCustomerRepository = assetCustomerRepository;
        }

        public async Task Add(AssetCustomer assetCustomer)
        {
            await _assetCustomerRepository.Add(assetCustomer);
        }

        public async Task Delete(AssetCustomer assetCustomer)
        {
            await _assetCustomerRepository.Delete(assetCustomer);
        }

        public async Task Update(AssetCustomer assetCustomer)
        {
            await _assetCustomerRepository.Update(assetCustomer);
        }
    }
}
