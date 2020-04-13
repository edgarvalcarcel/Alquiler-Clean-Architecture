using Alquiler.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Domain.Warehouses
{
   public class Warehouse : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
