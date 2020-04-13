using Alquiler.Domain.UserLogins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Application.Interfaces.Persistence
{
    public interface IUserLoginRepository : IRepository<UserLogin>
    {
    }
}
