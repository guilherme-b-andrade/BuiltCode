using BuiltCodeTest.Domain.Contracts;
using BuiltCodeTest.Repository.Context;
using System.Collections.Generic;
using System.Linq;

namespace BuiltCodeTest.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        protected readonly BuiltCodeTestContext BuiltCodeTestContext;

        public BaseRepository(BuiltCodeTestContext builtCodeTestContext)
        {
            BuiltCodeTestContext = builtCodeTestContext;
        }

        public void Save(TEntity entity)
        {
            BuiltCodeTestContext.Set<TEntity>().Add(entity);
            BuiltCodeTestContext.SaveChanges();
        }

     
        public IEnumerable<TEntity> GetAll()
        {
            return BuiltCodeTestContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return BuiltCodeTestContext.Set<TEntity>().Find(id);
        }

        public void Put(TEntity entity)
        {
            BuiltCodeTestContext.Set<TEntity>().Update(entity);
            BuiltCodeTestContext.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            BuiltCodeTestContext.Remove(entity);
            BuiltCodeTestContext.SaveChanges();
        }
        public void Dispose()
        {
            BuiltCodeTestContext.Dispose();
        }

    }
}
