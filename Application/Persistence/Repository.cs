using Domain.Entity;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace Generics.Application.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly GenericDbContext context;
        private readonly DbSet<TEntity> dbSet;

        public Repository(GenericDbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Find()
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetLists()
        {
            throw new NotImplementedException();
        }
    }
}
