using System.Linq;
using Wilcommerce.Core.Common.Domain.Events;
using Wilcommerce.Core.Common.Domain.Models;

namespace Wilcommerce.Core.Common.Domain.ReadModels
{
    /// <summary>
    /// Represents the interface for the common readmodels
    /// </summary>
    public interface ICommonDatabase
    {
        /// <summary>
        /// Get the list of settings
        /// </summary>
        IQueryable<GeneralSettings> Settings { get; }

        /// <summary>
        /// Get the list of users
        /// </summary>
        IQueryable<User> Users { get; }

        /// <summary>
        /// Get the list of events
        /// </summary>
        IQueryable<EventWrapper> Events { get; }
    }
}
