using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// The Generic Repository class exposes a set of methods that allow 
    /// create, read, update, and delete (CRUD) operations to be performed for any of the entities in our model. 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Deletes an entity
        /// </summary>
        /// <param name="entityToDelete"></param>
        void Delete(TEntity entityToDelete);

        /// <summary>
        /// Fetches an entity using a unique identifier 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        TEntity GetEntityByKey(object key);

        /// <summary>
        /// Adds a new entity
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// Allows you to query an entity
        /// </summary>
        /// <param name="filter">Lambda expression for filtering rows</param>
        /// <param name="orderBy">Lambda expression for sorting</param>
        /// <param name="includedProperties">Add an argument for each property that should be eager loaded</param>
        /// <param name="page">When pageSize is greater then 0 then will return a particular data page</param>
        /// <param name="pageSize">Number of items per page. 0 will return all data without pages</param>
        /// <returns>An IEnumerable of the type or null if no data is found</returns>
        IEnumerable<TEntity> Query(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int page = 1, int pageSize = 0, params Expression<Func<TEntity, object>>[] includedProperties);

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entityToUpdate"></param>
        void Update(TEntity entityToUpdate);
    }
}