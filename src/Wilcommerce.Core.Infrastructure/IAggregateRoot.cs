using System;

namespace Wilcommerce.Core.Infrastructure
{
    /// <summary>
    /// Represents an Aggregate root
    /// </summary>
    public interface IAggregateRoot
    {
        /// <summary>
        /// The aggregate root Id
        /// </summary>
        Guid Id { get; set; }
    }
}
