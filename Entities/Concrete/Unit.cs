using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Unit : IEntity
    {
        public Unit()
        {
            AssetWithoutBarcodes = new HashSet<AssetWithoutBarcode>();
        }

        public int UnitId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AssetWithoutBarcode> AssetWithoutBarcodes { get; set; }
    }
}
