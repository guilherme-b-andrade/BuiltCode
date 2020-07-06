using System;
using System.Collections.Generic;


namespace BuiltCodeTest.Domain.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Save(TEntity entity);
        TEntity GetById(int id);
        void Put(TEntity entity);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Remove(TEntity entity);

    }
}
