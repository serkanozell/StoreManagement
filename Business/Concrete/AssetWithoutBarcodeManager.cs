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
    public class AssetWithoutBarcodeManager : IAssetWithoutBarcodeService
    {
        IAssetWithoutBarcodeRepository _assetWithoutBarcodeRepository;

        public AssetWithoutBarcodeManager(IAssetWithoutBarcodeRepository assetWithoutBarcodeRepository)
        {
            _assetWithoutBarcodeRepository = assetWithoutBarcodeRepository;
        }

        public async Task Add(AssetWithoutBarcode assetWithoutBarcode)
        {
            await _assetWithoutBarcodeRepository.Add(assetWithoutBarcode);
        }

        public async Task Delete(AssetWithoutBarcode assetWithoutBarcode)
        {
            await _assetWithoutBarcodeRepository.Delete(assetWithoutBarcode);
        }

        public async Task Update(AssetWithoutBarcode assetWithoutBarcode)
        {
            await _assetWithoutBarcodeRepository.Update(assetWithoutBarcode);
        }
    }
}
