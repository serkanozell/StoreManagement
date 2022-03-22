using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class AssetType : IEntity
    {
        public AssetType()
        {
            Assets = new HashSet<Asset>();
        }

        public int AssetTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
    }
}
