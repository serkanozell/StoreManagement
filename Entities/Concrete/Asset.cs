using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Entities.Concrete
{
    public partial class Asset : IEntity
    {
        public Asset()
        {
            AssetBarcodes = new HashSet<AssetBarcode>();
            AssetCustomers = new HashSet<AssetCustomer>();
            AssetPersonnel = new HashSet<AssetPersonnel>();
            AssetStatuses = new HashSet<AssetStatus>();
            AssetWithoutBarcodes = new HashSet<AssetWithoutBarcode>();
            Comments = new HashSet<Comment>();
            Prices = new HashSet<Price>();
        }

        [Key]
        public int AssetId { get; set; }
        public int RegistrationNumber { get; set; }
        public int CompanyId { get; set; }
        public int GroupId { get; set; }
        public int AssetTypeId { get; set; }
        public int MasterDetailId { get; set; }
        public int PriceId { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public bool Guarantee { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? RetireDate { get; set; }


        public virtual AssetType AssetType { get; set; }
        public virtual Group Group { get; set; }
        public virtual MasterDetail MasterDetail { get; set; }
        public virtual Document Document { get; set; }
        public virtual ICollection<AssetBarcode> AssetBarcodes { get; set; }
        public virtual ICollection<AssetCustomer> AssetCustomers { get; set; }
        public virtual ICollection<AssetPersonnel> AssetPersonnel { get; set; }
        public virtual ICollection<AssetStatus> AssetStatuses { get; set; }
        public virtual ICollection<AssetWithoutBarcode> AssetWithoutBarcodes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
    }
}
