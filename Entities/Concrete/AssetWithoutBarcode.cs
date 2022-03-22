using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class AssetWithoutBarcode : IEntity
    {
        public int AssetWithoutBarcodeId { get; set; }
        public int AssetId { get; set; }
        public int UnitId { get; set; }
        public int Quantity { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
