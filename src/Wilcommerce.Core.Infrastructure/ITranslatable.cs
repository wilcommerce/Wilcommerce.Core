using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wilcommerce.Core.Infrastructure
{
    /// <summary>
    /// Represents a translatable entity
    /// </summary>
    public interface ITranslatable
    {
        /// <summary>
        /// Translate the entity
        /// </summary>
        /// <typeparam name="T">The translatable entity type</typeparam>
        /// <param name="language">The language to which translates the entity</param>
        /// <returns>The entity's translation</returns>
        ITranslation<T> Translate<T>(object language) where T : class, ITranslatable;
    }
}
