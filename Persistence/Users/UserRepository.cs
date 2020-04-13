using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.UserLogins;
using Alquiler.Domain.UserRoles;
using Alquiler.Domain.Users;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Users
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
