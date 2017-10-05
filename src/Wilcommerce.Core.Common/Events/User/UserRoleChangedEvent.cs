using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    /// <summary>
    /// User role changed
    /// </summary>
    public class UserRoleChangedEvent : DomainEvent
    {
        /// <summary>
        /// Get the user id
        /// </summary>
        public Guid UserId { get; private set; }

        /// <summary>
        /// Get the new role
        /// </summary>
        public Domain.Models.User.Roles Role { get; private set; }

        /// <summary>
        /// Construct the event
        /// </summary>
        /// <param name="userId">The user id</param>
        /// <param name="role">The new role</param>
        public UserRoleChangedEvent(Guid userId, Domain.Models.User.Roles role)
            : base(userId, typeof(Domain.Models.User))
        {
            UserId = userId;
            Role = role;
        }

        /// <summary>
        /// Convert the event to string
        /// </summary>
        /// <returns>The converted string</returns>
        public override string ToString()
        {
            return $"{FiredOn} - The user {UserId} changed the role to {Role}";
        }
    }
}
