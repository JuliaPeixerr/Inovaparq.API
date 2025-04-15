using Incubadora.Project.Domain.Command;

namespace Incubadora.Project.Domain.Infrastructure.Facade
{
    public interface IUsuarioFacade
    {
        void Create(CreateUsuarioCommand command);
        void Login(LoginCommand command);
    }
}
