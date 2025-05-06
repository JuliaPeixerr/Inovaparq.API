using Incubadora.Project.Domain.Command;
using Incubadora.Project.Domain.Models;
using Incubadora.Project.Domain.Query;

namespace Incubadora.Project.Domain.Infrastructure.Facade
{
    public interface IStartupFacade
    {
        Startup Save(SaveStartupCommand command);
        Startup Get(int id);
        List<Startup> GetAll(GetAllStartupQuery query);
    }
}
