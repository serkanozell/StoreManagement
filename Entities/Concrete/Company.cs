using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Company : IEntity
    {
        public Company()
        {
            Personnel = new HashSet<Personnel>();
        }

        public int CompanyId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Personnel> Personnel { get; set; }
    }
}
