using Incubadora.Project.Domain.Models;
using System.Linq.Expressions;

namespace Incubadora.Project.Database.Finders
{
    public class UsuarioFinder
    {
        private string? _nome;

        public UsuarioFinder Nome(string nome)
        {
            _nome = nome;
            return this;
        }

        public Expression<Func<Usuario, bool>> ToExpression()
            => usuario => (_nome == null || usuario.Nome == _nome);
    }
}
