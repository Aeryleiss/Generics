﻿namespace Generics.Domain.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Find();
        void Delete();
        IList<TEntity> GetLists();
    }
}
