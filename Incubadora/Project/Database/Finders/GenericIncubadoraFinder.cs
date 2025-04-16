using System.Linq.Expressions;

namespace Incubadora.Project.Database.Finders
{
    public class GenericIncubadoraFinder
    {
        private string? _descricao;
        private string? _containsDescricao;
        private int? _codigoStatus;

        public GenericIncubadoraFinder Descricao(string descricao)
        {
            _descricao = descricao;
            return this;
        }

        public GenericIncubadoraFinder ContainsDescricao(string containsDescricao)
        {
            _containsDescricao = containsDescricao;
            return this;
        }

        public GenericIncubadoraFinder CodigoStatus(int? codigoStatus) 
        {
            _codigoStatus = codigoStatus;
            return this;
        }

        public Expression<Func<Domain.Models.Incubadora, bool>> ToExpression()
            => (incubadora) => (_descricao == null || incubadora.Descricao == _descricao) &&
            (_containsDescricao == null || incubadora.Descricao.Contains(_containsDescricao)) &&
            (_codigoStatus == null || incubadora.CodigoStatus == _codigoStatus);
    }
}
