using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class AssetPersonnel : IEntity
    {
        public int AssetOwnerId { get; set; }
        public int AssetId { get; set; }
        public int PersonnelTypeId { get; set; }
        public int PersonnelId { get; set; }
        public DateTime Date { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Personnel Personnel { get; set; }
        public virtual PersonnelTypeId PersonnelType { get; set; }
    }
}
