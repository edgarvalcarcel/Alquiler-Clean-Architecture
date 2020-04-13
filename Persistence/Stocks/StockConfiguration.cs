using Alquiler.Domain.Stocks;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Stocks
{
    public class StockConfiguration : EntityTypeConfiguration<Stock>
    {
        public StockConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.EquipmentId).IsRequired();
            HasRequired(p => p.Equipment);
            Property(p => p.Quantity).IsRequired();
            Property(p => p.WarehouseId).IsRequired();
            HasRequired(p => p.Warehouse);
        }
    }
}
