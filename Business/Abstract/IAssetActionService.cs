using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAssetActionService
    {
        public Task Add(AssetAction assetAction);
        public Task Update(AssetAction assetAction);
        public Task Delete(AssetAction assetAction);
    }
}
