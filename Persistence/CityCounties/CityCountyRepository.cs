using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.CityCounties;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.CityCounties
{
    public class CityCountyRepository : Repository<CityCounty>, ICityCountyRepository
    {
        public CityCountyRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
