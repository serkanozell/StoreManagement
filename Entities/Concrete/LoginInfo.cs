using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class LoginInfo : IEntity
    {
        public LoginInfo()
        {
            PersonnelLoginInfos = new HashSet<PersonnelLoginInfo>();
        }

        public int LoginInfoId { get; set; }
        public string Username { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

        public virtual ICollection<PersonnelLoginInfo> PersonnelLoginInfos { get; set; }
    }
}
