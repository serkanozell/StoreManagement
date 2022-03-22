using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class RolePersonnel : IEntity
    {
        public int RolePersonelId { get; set; }
        public int PersonnelId { get; set; }
        public int RoleId { get; set; }
        public DateTime Date { get; set; }

        public virtual Personnel Personnel { get; set; }
        public virtual Role Role { get; set; }
    }
}
