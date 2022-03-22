using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Page : IEntity
    {
        public Page()
        {
            PageClaims = new HashSet<PageClaim>();
        }

        public int PageId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PageClaim> PageClaims { get; set; }
    }
}
