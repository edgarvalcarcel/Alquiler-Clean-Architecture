using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.BodyParts;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.BodyParts
{
    public class BodypartRepository : Repository<Bodypart>, IBodypartRepository
    {
        public BodypartRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}