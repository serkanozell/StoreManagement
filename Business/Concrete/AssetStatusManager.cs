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
    public class AssetStatusManager : IAssetStatusService
    {
        IAssetStatusRepository _assetStatusRepository;

        public AssetStatusManager(IAssetStatusRepository assetStatusRepository)
        {
            _assetStatusRepository = assetStatusRepository;
        }

        public async Task Add(AssetStatus assetStatus)
        {
            await _assetStatusRepository.Add(assetStatus);
        }

        public async Task Delete(AssetStatus assetStatus)
        {
            await _assetStatusRepository.Delete(assetStatus);
        }

        public async Task Update(AssetStatus assetStatus)
        {
            await _assetStatusRepository.Update(assetStatus);
        }
    }
}
