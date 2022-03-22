using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class ActionStatus : IEntity
    {
        public int ActionStatusId { get; set; }
        public int AssetActionId { get; set; }
        public int StatusId { get; set; }

        public virtual AssetAction AssetAction { get; set; }
        public virtual Status Status { get; set; }
    }
}
