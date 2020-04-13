using Alquiler.Domain.BodyParts;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.BodyParts
{
    public class BodypartConfiguration : EntityTypeConfiguration<Bodypart>
    {
        public BodypartConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(60);
            Property(p => p.Serial).IsRequired().HasMaxLength(60);
            Property(p => p.CategoryId).IsRequired();
            Property(p => p.Branding).IsRequired().HasMaxLength(60);
            Property(p => p.Cost).IsRequired().HasPrecision(15, 2);
            HasRequired(p => p.Category);
        }
    }
}
