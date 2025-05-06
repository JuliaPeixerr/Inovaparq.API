using Incubadora.Project.Database;
using Incubadora.Project.Domain.Models;
using Incubadora.Project.Domain.Repository.Interface;
using Incubadora.Project.Domain.Repository.Shared;

namespace Incubadora.Project.Domain.Repository
{
    public class StartupRepository : Repository<Startup>, IStartupRepository
    {
        public StartupRepository(ProjectContext context) : base(context)
        {
        }
    }
}
