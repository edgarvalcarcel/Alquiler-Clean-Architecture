using Alquiler.Domain.CityCounties;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.CityCounties
{
    public class CityCountyConfiguration : EntityTypeConfiguration<CityCounty>
    {
        public CityCountyConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(60); 
        }
    }
}
