using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.Articles;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Articles
{
    public class EquipmentRepository : Repository<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(IDatabaseContext database) : base(database)
        {
        }
    } 
}
