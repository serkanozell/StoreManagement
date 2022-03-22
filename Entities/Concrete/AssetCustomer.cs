using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class AssetCustomer : IEntity
    {
        public int AssetCustomerId { get; set; }
        public int AssetId { get; set; }
        public int CustomerId { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
