using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Entities.Concrete
{
    public partial class Claims : IEntity
    {
        public Claims()
        {
            PageClaims = new HashSet<PageClaim>();
        }

        [Key]
        public int ClaimId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PageClaim> PageClaims { get; set; }
    }
}
