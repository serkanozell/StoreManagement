using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class AssetBarcode : IEntity
    {
        public int AssetBarcodeId { get; set; }
        public int AssetId { get; set; }
        public string Barcode { get; set; }

        public virtual Asset Asset { get; set; }
    }
}
