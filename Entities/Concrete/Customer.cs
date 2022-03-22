using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Customer : IEntity
    {
        public Customer()
        {
            AssetCustomers = new HashSet<AssetCustomer>();
        }

        public int CustomerId { get; set; }
        public int SubscriptionNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<AssetCustomer> AssetCustomers { get; set; }
    }
}
