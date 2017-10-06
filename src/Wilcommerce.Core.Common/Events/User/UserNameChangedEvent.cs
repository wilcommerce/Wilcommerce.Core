using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    /// <summary>
    /// User name changed
    /// </summary>
    public class UserNameChangedEvent : DomainEvent
    {
        /// <summary>
        /// Get the user id
        /// </summary>
        public Guid UserId { get; private set; }

        /// <summary>
        /// Get the new name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Construct the event
        /// </summary>
        /// <param name="userId">The user id</param>
        /// <param name="name">The new name</param>
        public UserNameChangedEvent(Guid userId, string name)
            : base(userId, typeof(Domain.Models.User))
        {
            UserId = userId;
            Name = name;
        }

        /// <summary>
        /// Convert the event to string
        /// </summary>
        /// <returns>The converted string</returns>
        public override string ToString()
        {
            return $"{FiredOn} - Name changed to {Name} for user {UserId}";
        }
    }
}
