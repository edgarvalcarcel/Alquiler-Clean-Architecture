using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.Projects;
using Alquiler.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Projects
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
