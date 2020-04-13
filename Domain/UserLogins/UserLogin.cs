using Alquiler.Domain.Common;
using Alquiler.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Domain.UserLogins
{
    public class UserLogin : IEntity
    {
        public int Id { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
