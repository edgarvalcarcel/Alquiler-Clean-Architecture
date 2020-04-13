using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.Stocks;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Stocks
{
    public class StockRepository : Repository<Stock>, IStockRepository
    {
        public StockRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
