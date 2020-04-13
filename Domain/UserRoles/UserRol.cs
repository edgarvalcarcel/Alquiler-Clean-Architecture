using Alquiler.Domain.Common;
using Alquiler.Domain.Roles;
using Alquiler.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Domain.UserRoles
{
    public class UserRol:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RoleId { get; set; }
        public Rol Rol { get; set; }
    }
}
