using Alquiler.Domain.Articles;
using Alquiler.Domain.BodyParts;
using Alquiler.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Domain.Compositions
{
    public class Composition : IEntity
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        public int BodyPartId { get; set; }
        public Bodypart Bodypart { get; set; }
        public int Quantity { get; set; }
    }
}
