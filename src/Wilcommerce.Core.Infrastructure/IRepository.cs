using System;
using System.Threading.Tasks;

namespace Wilcommerce.Core.Infrastructure
{
    /// <summary>
    /// Represents a generic repository for the aggregate's persistence
    /// </summary>
    public interface IRepository : IDisposable
    {
        /// <summary>
        /// Add an aggregate to the repository
        /// </summary>
        /// <typeparam name="TModel">The aggregate's type</typeparam>
        /// <param name="model">The aggregate to add</param>
        void Add<TModel>(TModel model) where TModel : class, IAggregateRoot;

        /// <summary>
        /// Gets the aggregate based on the specified key
        /// </summary>
        /// <typeparam name="TModel">The aggregate's type</typeparam>
        /// <param name="key">The key of the aggregate to search</param>
        /// <returns>The aggregate found</returns>
        TModel GetByKey<TModel>(Guid key) where TModel : class, IAggregateRoot;

        /// <summary>
        /// Async method. Gets the aggregate based on the specified key
        /// </summary>
        /// <typeparam name="TModel">The aggregate's type</typeparam>
        /// <param name="key">The key of the aggregate to search</param>
        /// <returns>The aggregate found</returns>
        Task<TModel> GetByKeyAsync<TModel>(Guid key) where TModel : class, IAggregateRoot;

        /// <summary>
        /// Saves all the changes made on the aggregate
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Async method. Saves all the changes made on the aggregate
        /// </summary>
        /// <returns></returns>
        Task SaveChangesAsync();
    }
}
