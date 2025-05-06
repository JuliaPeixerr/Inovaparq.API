using Incubadora.Project.Database.Finders;
using Incubadora.Project.Domain.Command;
using Incubadora.Project.Domain.Infrastructure.Facade;
using Incubadora.Project.Domain.Models;
using Incubadora.Project.Domain.Query;
using Incubadora.Project.Domain.Repository.Interface;

namespace Incubadora.Project.Infrastructure.Facade
{
    public class StartupFacade : IStartupFacade
    {
        private IStartupRepository _repository;
        private IStartupStatusRepository _statusRepository;

        public StartupFacade(IStartupRepository repository,
            IStartupStatusRepository statusRepository)
            => (_repository, _statusRepository) 
            = (repository, statusRepository);

        public Startup Save(SaveStartupCommand command)
        {
            var entity = new Startup();
            entity.Descricao = command.Descricao;

            if (command.Id == null)
                return _repository.Create(entity);
            return _repository.Update(entity);
        }

        public Startup Get(int id)
            => _repository.Get(id);

        public List<Startup> GetAll(GetAllStartupQuery query)
            => _repository.GetAll(new GenericStartupFinder()
                .ContainsDescricao(query.Descricao)
                .ToExpression());
    }
}
