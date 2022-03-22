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
    public class AssetBarcodeManager : IAssetBarcodeService
    {
        IAssetBarcodeRepository _assetBarcodeRepository;

        public AssetBarcodeManager(IAssetBarcodeRepository assetBarcodeRepository)
        {
            _assetBarcodeRepository = assetBarcodeRepository;
        }

        public async Task Add(AssetBarcode assetBarcode)
        {
            await _assetBarcodeRepository.Add(assetBarcode);
        }

        public async Task Delete(AssetBarcode assetBarcode)
        {
            await _assetBarcodeRepository.Delete(assetBarcode);
        }

        public async Task Update(AssetBarcode assetBarcode)
        {
            await _assetBarcodeRepository.Update(assetBarcode);
        }
    }
}
