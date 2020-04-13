using Alquiler.Domain.UserClaims;
using Alquiler.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Users
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Email).HasMaxLength(256);
            Property(p => p.EmailConfirmed);
            Property(p => p.PasswordHash);
            Property(p => p.SecurityStamp);
            Property(p => p.PhoneNumber);
            Property(p => p.PhoneNumberConfirmed);
            Property(p => p.TwoFactorEnabled);
            Property(p => p.LockoutEndDateUtc);
            Property(p => p.LockoutEnabled);
            Property(p => p.AccessFailedCount);
            Property(p => p.UserName).IsRequired().HasMaxLength(256);
        }
    }
}