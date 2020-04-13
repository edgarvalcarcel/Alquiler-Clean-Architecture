using Alquiler.Domain.Articles;
using Alquiler.Domain.Categories;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Articles
{
    public class EquipmentConfiguration
        : EntityTypeConfiguration<Equipment>
    {
        public EquipmentConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(60);
            Property(p => p.LongName).IsRequired().HasMaxLength(60);
            Property(p => p.CategoryId).IsRequired();
            Property(p => p.WarehouseId).IsRequired();
            Property(p => p.Serial).IsRequired().HasMaxLength(30); ;
            Property(p => p.Branding).IsRequired();
            Property(p => p.Cost).IsRequired().HasPrecision(15, 2);
            Property(p => p.RentPrice).IsRequired().HasPrecision(15, 2);
            Property(p => p.SalePrice).HasPrecision(15, 2);
            HasRequired(p => p.Category);
            HasRequired(p => p.Warehouse);
            //Property(p => p.Buydate).IsRequired();
            //Property(p => p.IsGeneric).IsRequired();
            //Property(p => p.IsCompound).IsRequired();
            //Property(p => p.IsAsset).IsRequired();
            //Property(p => p.Seller).IsRequired();
        }
    }
}