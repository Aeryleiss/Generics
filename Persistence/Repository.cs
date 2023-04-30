using Generics.Core.Entity;
using Generics.Interface;

namespace Generics.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal GenericDbContext context;

        public void Add(TEntity entity)
        {
            context.Add(entity);
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
