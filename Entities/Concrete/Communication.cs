using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Communication : IEntity
    {
        public int CommunicationId { get; set; }
        public int PersonnelId { get; set; }
        public int CommTypeId { get; set; }
        public string Description { get; set; }

        public virtual CommType CommType { get; set; }
        public virtual Personnel Personnel { get; set; }
    }
}
