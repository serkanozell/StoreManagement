using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class PersonnelLoginInfo : IEntity
    {
        public int PersonnelLoginInfoId { get; set; }
        public int PersonnelId { get; set; }
        public int LoginInfoId { get; set; }
        public DateTime Date { get; set; }

        public virtual LoginInfo LoginInfo { get; set; }
        public virtual Personnel Personnel { get; set; }
    }
}
