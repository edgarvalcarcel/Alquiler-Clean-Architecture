using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.UserLogins;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.UserLogins
{
    public class UserLoginRepository : Repository<UserLogin>, IUserLoginRepository
    {
        public UserLoginRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
