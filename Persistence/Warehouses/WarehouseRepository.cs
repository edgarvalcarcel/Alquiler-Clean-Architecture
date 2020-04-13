using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.Stocks;
using Alquiler.Domain.Warehouses;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Warehouses
{
    public class WarehouseRepository : Repository<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
