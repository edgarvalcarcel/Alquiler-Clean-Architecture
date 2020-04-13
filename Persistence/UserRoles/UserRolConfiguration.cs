using Alquiler.Domain.UserLogins;
using Alquiler.Domain.UserRoles;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.UserRoles
{
    public class UserRolConfiguration : EntityTypeConfiguration<UserRol>
    {
        public UserRolConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.UserId).IsRequired();
            Property(p => p.RoleId).IsRequired();
            HasRequired(p => p.Rol);
            HasRequired(p => p.User);
        }
    }
}