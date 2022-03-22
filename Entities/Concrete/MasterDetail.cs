using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class MasterDetail : IEntity
    {
        public MasterDetail()
        {
            Assets = new HashSet<Asset>();
        }

        public int MasterDetailId { get; set; }
        public int MasterId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
    }
}
