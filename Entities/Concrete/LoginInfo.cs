using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class LoginInfo : IEntity
    {
        public int LoginInfoId { get; set; }
        public string Username { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
