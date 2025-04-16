using Incubadora.Project.Domain.Command;
using Incubadora.Project.Domain.Models;

namespace Incubadora.Project.Domain.Infrastructure.Facade
{
    public interface IUsuarioFacade
    {
        Usuario Save(CreateUsuarioCommand command);
        void Login(LoginCommand command);
    }
}
