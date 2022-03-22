using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class AssetAction : IEntity
    {
        public AssetAction()
        {
            ActionStatuses = new HashSet<ActionStatus>();
        }

        public int AssetActionId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ActionStatus> ActionStatuses { get; set; }
    }
}
