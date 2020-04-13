using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.Projects;
using Alquiler.Domain.UserClaims;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.UserClaims
{
    public class UserClaimRepository : Repository<UserClaim>, IUserClaimRepository
    {
        public UserClaimRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
