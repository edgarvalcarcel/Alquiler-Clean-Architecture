using Alquiler.Domain.UserClaims;
using Alquiler.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.UserClaims
{
    public class UserClaimConfiguration : EntityTypeConfiguration<UserClaim>
    {
        public UserClaimConfiguration()
        { 
            HasKey(p => p.Id);
            Property(p => p.Id).IsRequired();
            Property(p => p.UserId).IsRequired();
            Property(p => p.ClaimType);
            Property(p => p.ClaimValue);
            HasRequired(p => p.User);
        }
    }
}
