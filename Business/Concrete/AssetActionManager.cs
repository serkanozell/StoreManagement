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
    public class AssetActionManager : IAssetActionService
    {
        IAssetActionRepository _assetActionRepository;

        public AssetActionManager(IAssetActionRepository assetActionRepository)
        {
            _assetActionRepository = assetActionRepository;
        }

        public async Task Add(AssetAction assetAction)
        {
            await _assetActionRepository.Add(assetAction);
        }

        public async Task Delete(AssetAction assetAction)
        {
            await _assetActionRepository.Delete(assetAction);
        }

        public async Task Update(AssetAction assetAction)
        {
            await _assetActionRepository.Update(assetAction);
        }
    }
}
