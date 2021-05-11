using System;
using System.Collections.Generic;

#nullable disable

namespace MyOrganizator.Entities.Models
{
    public partial class User
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
