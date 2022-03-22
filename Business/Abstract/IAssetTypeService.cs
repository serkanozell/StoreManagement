using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAssetTypeService
    {
        public Task Add(AssetType assetType);
        public Task Update(AssetType assetType);
        public Task Delete(AssetType assetType);
    }
}
