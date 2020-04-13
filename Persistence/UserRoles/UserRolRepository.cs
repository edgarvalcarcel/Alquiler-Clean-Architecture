using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.UserLogins;
using Alquiler.Domain.UserRoles;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.UserRoles
{
    public class UserRolRepository : Repository<UserRol>, IUserRolRepository
    {
        public UserRolRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
