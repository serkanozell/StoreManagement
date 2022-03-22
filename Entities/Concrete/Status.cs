using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Status : IEntity
    {
        public Status()
        {
            ActionStatuses = new HashSet<ActionStatus>();
            AssetStatuses = new HashSet<AssetStatus>();
        }

        public int StatusId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ActionStatus> ActionStatuses { get; set; }
        public virtual ICollection<AssetStatus> AssetStatuses { get; set; }
    }
}
