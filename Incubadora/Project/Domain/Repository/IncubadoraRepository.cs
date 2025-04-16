using Incubadora.Project.Database;
using Incubadora.Project.Domain.Repository.Interface;
using Incubadora.Project.Domain.Repository.Shared;

namespace Incubadora.Project.Domain.Repository
{
    public class IncubadoraRepository : Repository<Models.Incubadora>, IIncubadoraRepository
    {
        public IncubadoraRepository(ProjectContext context) : base(context)
        {
        }
    }
}
