using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class PersonnelType : IEntity
    {
        public PersonnelType()
        {
            AssetPersonnel = new HashSet<AssetPersonnel>();
        }

        public int PersonnelTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AssetPersonnel> AssetPersonnel { get; set; }
    }
}
