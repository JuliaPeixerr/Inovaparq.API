using Incubadora.Project.Database.Finders;
using Incubadora.Project.Domain.Command;
using Incubadora.Project.Domain.Infrastructure.Facade;
using Incubadora.Project.Domain.Query;
using Incubadora.Project.Domain.Repository.Interface;

namespace Incubadora.Project.Infrastructure.Facade
{
    public class IncubadoraFacade : IIncubadoraFacade
    {
        private IIncubadoraRepository _repository;
        private IIncubadoraStatusRepository _statusRepository;

        public IncubadoraFacade(IIncubadoraRepository repository,
            IIncubadoraStatusRepository statusRepository)
            => (_repository, _statusRepository) 
            = (repository, statusRepository);

        public Domain.Models.Incubadora Save(SaveIncubadoraCommand command)
        {
            var entity = new Domain.Models.Incubadora();
            entity.Descricao = command.Descricao;
            entity.CodigoStatus = command.CodigoStatus;
            entity.Ativo = true;

            if (command.Id == null)
                return _repository.Create(entity);
            return _repository.Update(entity);
        }

        public Domain.Models.Incubadora Get(int id)
            => _repository.Get(id);

        public List<Domain.Models.Incubadora> GetAll(GetAllIncubadoraQuery query)
            => _repository.GetAll(new GenericIncubadoraFinder()
                .CodigoStatus(query.CodigoStatus)
                .ContainsDescricao(query.Descricao)
                .ToExpression());
    }
}
