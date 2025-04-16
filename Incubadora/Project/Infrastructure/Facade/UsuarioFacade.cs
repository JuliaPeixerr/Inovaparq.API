using Incubadora.Project.Database.Finders;
using Incubadora.Project.Domain.Command;
using Incubadora.Project.Domain.Infrastructure.Facade;
using Incubadora.Project.Domain.Infrastructure.Service;
using Incubadora.Project.Domain.Models;
using Incubadora.Project.Domain.Repository.Interface;

namespace Incubadora.Project.Infrastructure.Facade
{
    public class UsuarioFacade : IUsuarioFacade
    {
        private IUsuarioRepository _repository;
        private ICryptographyService _cryptographyService;

        public UsuarioFacade(IUsuarioRepository repository,
            ICryptographyService cryptographyService)
            => (_repository, _cryptographyService)
            = (repository, cryptographyService);

        public Usuario Save(CreateUsuarioCommand command)
        {
            var cryptoPassword = _cryptographyService.Cryptograph(command.Senha);
            
            var entity = new Usuario();
            entity.Nome = command.Nome;
            entity.Senha = cryptoPassword;

            if (command.Id == null)
                return _repository.Create(entity);
            return _repository.Update(entity);
        }

        public void Login(LoginCommand command)
        {
            var usuario = _repository.Get(new GenericUsuarioFinder()
                .Nome(command.Nome).ToExpression());

            if (usuario == null)
                throw new Exception("Usuário não encontrado");

            var descryptoPassword = _cryptographyService.Descryptograph(usuario.Senha);
            if (command.Senha != descryptoPassword)
                throw new Exception("Senha incorreta");
        }
    }
}
