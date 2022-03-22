using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class PageClaim : IEntity
    {
        public int PageClaimId { get; set; }
        public int RoleId { get; set; }
        public int PageId { get; set; }
        public int ClaimId { get; set; }
        public DateTime Date { get; set; }

        public virtual Claims Claim { get; set; }
        public virtual Page Page { get; set; }
        public virtual Role Role { get; set; }
    }
}
