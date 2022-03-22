using System;
using System.Collections.Generic;

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
            PersonnelLoginInfos = new HashSet<PersonnelLoginInfo>();
            RolePersonnel = new HashSet<RolePersonnel>();
        }

        public int PersonnelId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MasterId { get; set; }
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<AssetPersonnel> AssetPersonnel { get; set; }
        public virtual ICollection<AssetStatus> AssetStatuses { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Communication> Communications { get; set; }
        public virtual ICollection<PersonnelLoginInfo> PersonnelLoginInfos { get; set; }
        public virtual ICollection<RolePersonnel> RolePersonnel { get; set; }
    }
}
