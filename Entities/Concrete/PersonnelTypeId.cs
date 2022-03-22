using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class PersonnelTypeId : IEntity
    {
        public PersonnelTypeId()
        {
            AssetPersonnel = new HashSet<AssetPersonnel>();
        }

        public int PersonnelTypeId1 { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AssetPersonnel> AssetPersonnel { get; set; }
    }
}
