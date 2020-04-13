using Alquiler.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Roles
{
    public class RolConfiguration : EntityTypeConfiguration<Rol>
    {
        public RolConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).IsRequired();
            Property(p => p.Name).IsRequired().HasMaxLength(256);
        }
    }
}