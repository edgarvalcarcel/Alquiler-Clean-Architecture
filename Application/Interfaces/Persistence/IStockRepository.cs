using Alquiler.Domain.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Application.Interfaces.Persistence
{
    public interface IStockRepository : IRepository<Stock>
    {
    }
}
