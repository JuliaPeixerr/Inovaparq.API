using System.Linq.Expressions;

namespace Incubadora.Project.Domain.Repository.Shared
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        T? Get(int id);
        T? Get(string id);
        T? Get(Expression<Func<T, bool>> expression);
        T Create(T entity);
        T Update(T entity);
        void Delete(int id);
    }
}
