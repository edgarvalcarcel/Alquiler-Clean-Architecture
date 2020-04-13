using Alquiler.Domain.Compositions;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Compositions
{
    public class CompositionConfiguration : EntityTypeConfiguration<Composition>
    {
        public CompositionConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.EquipmentId).IsRequired();
            Property(p => p.BodyPartId).IsRequired();
            Property(p => p.Quantity).IsRequired();
            HasRequired(p => p.Equipment);
            HasRequired(p => p.Bodypart);
        }
    }
}
