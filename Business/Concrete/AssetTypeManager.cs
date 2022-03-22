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
    public class AssetTypeManager : IAssetTypeService
    {
        IAssetTypeRepository _assetTypeRepository;

        public AssetTypeManager(IAssetTypeRepository assetTypeRepository)
        {
            _assetTypeRepository = assetTypeRepository;
        }

        public async Task Add(AssetType assetType)
        {
            await _assetTypeRepository.Add(assetType);
        }

        public async Task Delete(AssetType assetType)
        {
            await _assetTypeRepository.Delete(assetType);
        }

        public async Task Update(AssetType assetType)
        {
            await _assetTypeRepository.Update(assetType);
        }
    }
}
