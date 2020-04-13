using Alquiler.Domain.Common;
using Alquiler.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Domain.UserClaims
{
   public class UserClaim : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}
