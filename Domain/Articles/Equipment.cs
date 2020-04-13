using Alquiler.Domain.Categories;
using Alquiler.Domain.Common;
using Alquiler.Domain.Warehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Domain.Articles
{
    public class Equipment : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LongName { get; set; }
        public string Serial { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } 
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public string Branding { get; set; }
        public string Seller { get; set; }
        public DateTime Buydate { get; set; }
        public Decimal Cost { get; set; }
        public Decimal SalePrice { get; set; }
        public Decimal RentPrice { get; set; } 
        public Boolean IsCompound { get; set; }
    }
}
