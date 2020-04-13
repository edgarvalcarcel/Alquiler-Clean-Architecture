using Alquiler.Domain.Categories;
using Alquiler.Domain.Common;
using Alquiler.Domain.Warehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Domain.BodyParts
{
   public class Bodypart : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Serial { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Branding { get; set; }
        public Decimal Cost { get; set; }
    }
}
