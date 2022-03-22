using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class PersonnelTeam : IEntity
    {
        public int PersonnelTeamId { get; set; }
        public int PersonnelId { get; set; }
        public int TeamId { get; set; }
        public DateTime Date { get; set; }
    }
}
