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
    public class AssetPersonnelManager : IAssetPersonnelService
    {
        IAssetPersonnelRepository _assetPersonnelRepository;

        public AssetPersonnelManager(IAssetPersonnelRepository assetPersonnelRepository)
        {
            _assetPersonnelRepository = assetPersonnelRepository;
        }

        public async Task Add(AssetPersonnel assetPersonnel)
        {
            await _assetPersonnelRepository.Add(assetPersonnel);
        }

        public async Task Delete(AssetPersonnel assetPersonnel)
        {
            await _assetPersonnelRepository.Delete(assetPersonnel);
        }

        public async Task Update(AssetPersonnel assetPersonnel)
        {
            await _assetPersonnelRepository.Delete(assetPersonnel);
        }
    }
}
