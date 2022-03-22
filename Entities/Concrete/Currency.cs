using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Currency : IEntity
    {
        public Currency()
        {
            Prices = new HashSet<Price>();
        }

        public int CurrencyId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Price> Prices { get; set; }
    }
}
