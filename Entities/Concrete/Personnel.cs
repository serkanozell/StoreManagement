using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Entities.Concrete
{
    public partial class Personnel : IEntity
    {
        public Personnel()
        {
            AssetPersonnel = new HashSet<AssetPersonnel>();
            AssetStatuses = new HashSet<AssetStatus>();
            Comments = new HashSet<Comment>();
            Communications = new HashSet<Communication>();
            RolePersonnel = new HashSet<RolePersonnel>();
        }

        [Key]
        public int PersonnelId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public int MasterId { get; set; }

        [ForeignKey("CompanyID")]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<AssetPersonnel> AssetPersonnel { get; set; }
        public virtual ICollection<AssetStatus> AssetStatuses { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Communication> Communications { get; set; }
        public virtual ICollection<RolePersonnel> RolePersonnel { get; set; }
    }
}
