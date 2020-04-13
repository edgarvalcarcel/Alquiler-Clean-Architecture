using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.Compositions;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Compositions
{
    public class CompositionRepository : Repository<Composition>, ICompositionRepository
    {
        public CompositionRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
