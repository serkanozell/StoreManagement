using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAssetCustomerService
    {
        public Task Add(AssetCustomer assetCustomer);
        public Task Update(AssetCustomer assetCustomer);
        public Task Delete(AssetCustomer assetCustomer);
    }
}
