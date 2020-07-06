using System;
using System.Collections.Generic;


namespace BuiltCodeTest.Domain.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {

        TEntity Get(int id);
        TEntity GetById(int id);
        void Put(TEntity entity);
        void Save(TEntity entity);
        void Remove(TEntity entity);
        IEnumerable<TEntity> GetAll();

    }
}
