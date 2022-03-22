using DataAccess.Abstract;
using DataAccess.RepositoryPattern;
using Entities.Concrete;
using Entities.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class AssetRepository : EfRepoBase<Asset, StoreManagementDbContext>, IAssetRepository
    {
        public async Task<Asset> GetAssetByBarcode(string barcodeNumber)
        {
            using (StoreManagementDbContext db = new StoreManagementDbContext())
            {
                var result = await (from a in db.AssetBarcodes
                                    join ab in db.Assets on a.AssetId equals ab.AssetId
                                    where a.Barcode == barcodeNumber
                                    select ab
                              ).FirstOrDefaultAsync();
                return result;
            }
        }
    }
}
