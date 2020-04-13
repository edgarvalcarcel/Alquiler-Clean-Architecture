using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.Roles;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Roles
{
   public class RolRepository : Repository<Rol>, IRolRepository
    {
        public RolRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
