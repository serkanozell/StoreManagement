using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Role : IEntity
    {
        public Role()
        {
            PageClaims = new HashSet<PageClaim>();
            RolePersonnel = new HashSet<RolePersonnel>();
        }

        public int RoleId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PageClaim> PageClaims { get; set; }
        public virtual ICollection<RolePersonnel> RolePersonnel { get; set; }
    }
}
