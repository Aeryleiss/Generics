

namespace Generics.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        void Find();
        void Delete();
        IList<TEntity> GetLists();
    }
}
