using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAssetBarcodeService
    {
        public Task Add(AssetBarcode assetBarcode);
        public Task Update(AssetBarcode assetBarcode);
        public Task Delete(AssetBarcode assetBarcode);
    }
}
