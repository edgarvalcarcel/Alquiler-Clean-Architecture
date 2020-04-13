using Alquiler.Domain.Warehouses;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Warehouses
{
    public class WarehouseConfiguration : EntityTypeConfiguration<Warehouse>
    {
        public WarehouseConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired();
        }
    }
}
