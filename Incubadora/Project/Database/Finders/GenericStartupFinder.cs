using System.Linq.Expressions;

namespace Incubadora.Project.Database.Finders
{
    public class GenericStartupFinder
    {
        private string? _descricao;
        private string? _containsDescricao;

        public GenericStartupFinder Descricao(string descricao)
        {
            _descricao = descricao;
            return this;
        }

        public GenericStartupFinder ContainsDescricao(string containsDescricao)
        {
            _containsDescricao = containsDescricao;
            return this;
        }

        public Expression<Func<Domain.Models.Startup, bool>> ToExpression()
            => (incubadora) => (_descricao == null || incubadora.Descricao == _descricao) &&
            (_containsDescricao == null || incubadora.Descricao.Contains(_containsDescricao));
    }
}
