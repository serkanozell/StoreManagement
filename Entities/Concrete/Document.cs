using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Document : IEntity
    {
        public int DocumentId { get; set; }
        public int AssetId { get; set; }
        public int PageCode { get; set; }
        public string FilePath { get; set; }

        public virtual Asset DocumentNavigation { get; set; }
    }
}
