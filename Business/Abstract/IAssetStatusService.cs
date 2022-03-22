using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAssetStatusService
    {
        public Task Add(AssetStatus assetStatus);
        public Task Update(AssetStatus assetStatus);
        public Task Delete(AssetStatus assetStatus);
    }
}
