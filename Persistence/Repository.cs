using Generics.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //internal IDBContext dbContext;
        //internal IDBSetbTEntity> dbSet;

        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
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
