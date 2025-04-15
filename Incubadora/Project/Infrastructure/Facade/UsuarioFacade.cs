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
        private IUsuarioRepository _usuarioRepository;
        private ICryptographyService _cryptographyService;

        public UsuarioFacade(IUsuarioRepository usuarioRepository,
            ICryptographyService cryptographyService)
            => (_usuarioRepository, _cryptographyService)
            = (usuarioRepository, cryptographyService);

        public void Create(CreateUsuarioCommand command)
        {
            var cryptoPassword = _cryptographyService.Cryptograph(command.Senha);
            
            var entity = new Usuario();
            entity.Nome = command.Nome;
            entity.Senha = cryptoPassword;

            _usuarioRepository.Create(entity);
        }

        public void Login(LoginCommand command)
        {
            var usuario = _usuarioRepository.Get(new UsuarioFinder()
                .Nome(command.Nome).ToExpression());

            if (usuario == null)
                throw new Exception("Usuário não encontrado");

            var descryptoPassword = _cryptographyService.Descryptograph(usuario.Senha);
            if (command.Senha != descryptoPassword)
                throw new Exception("Senha incorreta");
        }
    }
}
