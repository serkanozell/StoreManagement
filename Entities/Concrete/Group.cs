using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Group : IEntity
    {
        public Group()
        {
            Assets = new HashSet<Asset>();
        }

        public int GroupId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
    }
}
