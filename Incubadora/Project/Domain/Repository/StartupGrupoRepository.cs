using Incubadora.Project.Database;
using Incubadora.Project.Domain.Models;
using Incubadora.Project.Domain.Repository.Interface;
using Incubadora.Project.Domain.Repository.Shared;

namespace Incubadora.Project.Domain.Repository
{
    public class StartupGrupoRepository : Repository<StartupGrupo>, IStartupGrupoRepository
    {
        public StartupGrupoRepository(ProjectContext context) : base(context)
        {
        }
    }
}
