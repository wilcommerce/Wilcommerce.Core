using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    /// <summary>
    /// User password changed
    /// </summary>
    public class UserPasswordChangedEvent : DomainEvent
    {
        /// <summary>
        /// Get the user id
        /// </summary>
        public Guid UserId { get; private set; }

        /// <summary>
        /// Construct the event
        /// </summary>
        /// <param name="userId">The user id</param>
        public UserPasswordChangedEvent(Guid userId)
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
            return $"{FiredOn} - Password changed for user {UserId}";
        }
    }
}
