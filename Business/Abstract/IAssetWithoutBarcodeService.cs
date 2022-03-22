using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAssetWithoutBarcodeService
    {
        public Task Add(AssetWithoutBarcode assetWithoutBarcode);
        public Task Update(AssetWithoutBarcode assetWithoutBarcode);
        public Task Delete(AssetWithoutBarcode assetWithoutBarcode);
    }
}
