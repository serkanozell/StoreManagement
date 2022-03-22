using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class CommType : IEntity
    {
        public CommType()
        {
            Communications = new HashSet<Communication>();
        }

        public int CommTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Communication> Communications { get; set; }
    }
}
