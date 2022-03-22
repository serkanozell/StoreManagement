using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAssetService
    {
        public Task<List<Asset>> GetAll();
        public Task<Asset> GetById(int assetId);
        public Task<Asset> GetByBarcode(string barcodeNumber);
        public Task Add(Asset asset);
        public Task Update(Asset asset);
        public Task Delete(Asset asset);
    }
}
