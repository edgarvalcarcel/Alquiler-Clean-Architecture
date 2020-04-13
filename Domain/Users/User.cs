using Alquiler.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Domain.Users
{
    public class User: IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public Boolean EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public Boolean PhoneNumberConfirmed { get; set; }
        public Boolean TwoFactorEnabled { get; set; }
        public DateTime LockoutEndDateUtc { get; set; }
        public Boolean LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
    }
}
