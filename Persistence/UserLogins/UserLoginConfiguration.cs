using Alquiler.Domain.UserLogins;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.UserLogins
{
    public class UserLoginConfiguration : EntityTypeConfiguration<UserLogin>
    {
        public UserLoginConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).IsRequired(); ;
            Property(p => p.LoginProvider).IsRequired().HasMaxLength(128);
            Property(p => p.ProviderKey).IsRequired().HasMaxLength(128);
            HasRequired(p => p.User);
        }
    }
}