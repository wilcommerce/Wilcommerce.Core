using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wilcommerce.Core.Infrastructure
{
    /// <summary>
    /// Represents an entity translation
    /// </summary>
    /// <typeparam name="T">The translatable entity type</typeparam>
    public interface ITranslation<T> where T : class, ITranslatable
    {
        /// <summary>
        /// Get or set the language of the translation
        /// </summary>
        object Language { get; set; }

        /// <summary>
        /// Get the translated original entity
        /// </summary>
        T Translated { get; }
    }
}
