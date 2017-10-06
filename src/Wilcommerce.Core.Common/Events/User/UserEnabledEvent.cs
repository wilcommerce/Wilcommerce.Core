using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    /// <summary>
    /// User enabled
    /// </summary>
    public class UserEnabledEvent : DomainEvent
    {
        /// <summary>
        /// Get the user id
        /// </summary>
        public Guid UserId { get; private set; }

        /// <summary>
        /// Construct the event
        /// </summary>
        /// <param name="userId">The user id</param>
        public UserEnabledEvent(Guid userId)
            : base(userId, typeof(Domain.Models.User))
        {
            UserId = userId;
        }

        /// <summary>
        /// Convert the event to string
        /// </summary>
        /// <returns>The converted string</returns>
        public override string ToString()
        {
            return $"{FiredOn} - User {UserId} enabled";
        }
    }
}
