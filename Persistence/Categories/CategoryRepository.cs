using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.Categories;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Categories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
