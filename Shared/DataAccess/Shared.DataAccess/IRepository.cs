using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity entityToDelete);
        TEntity GetEntityByKey(object key);
        void Insert(TEntity entity);
        IEnumerable<TEntity> Query(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int page = 1, int pageSize = 0, params Expression<Func<TEntity, object>>[] includedProperties);
        void Update(TEntity entityToUpdate);
    }
}