using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class AssetStatus : IEntity
    {
        public int AssetStatusId { get; set; }
        public int AssetId { get; set; }
        public int PersonnelId { get; set; }
        public int StatusId { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Personnel Personnel { get; set; }
        public virtual Status Status { get; set; }
    }
}
