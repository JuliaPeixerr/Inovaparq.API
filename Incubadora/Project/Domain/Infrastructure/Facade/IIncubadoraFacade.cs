using Incubadora.Project.Domain.Command;
using Incubadora.Project.Domain.Query;

namespace Incubadora.Project.Domain.Infrastructure.Facade
{
    public interface IIncubadoraFacade
    {
        Models.Incubadora Save(SaveIncubadoraCommand command);
        Models.Incubadora Get(int id);
        List<Models.Incubadora> GetAll(GetAllIncubadoraQuery query);
    }
}
