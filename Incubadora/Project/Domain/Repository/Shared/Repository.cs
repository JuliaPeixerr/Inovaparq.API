using Incubadora.Project.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Incubadora.Project.Domain.Repository.Shared
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ProjectContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ProjectContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public List<T> GetAll()
            => _dbSet.ToList();

        public List<T> GetAll(Expression<Func<T, bool>> expression)
            => _dbSet.Where(expression).ToList();

        public T? Get(int id)
            => _dbSet.Find(id);

        public T? Get(string id)
            => _dbSet.Find(id);

        public T? Get(Expression<Func<T, bool>> expression)
            => _dbSet.Where(expression).FirstOrDefault();

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = Get(id);

            if (entity != null)
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
