using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    /// <summary>
    /// User email changed
    /// </summary>
    public class UserEmailChangedEvent : DomainEvent
    {
        /// <summary>
        /// Get the user id
        /// </summary>
        public Guid UserId { get; private set; }

        /// <summary>
        /// Get the user email
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Construct the event
        /// </summary>
        /// <param name="userId">The user id</param>
        /// <param name="email">The user email</param>
        public UserEmailChangedEvent(Guid userId, string email)
            : base(userId, typeof(Domain.Models.User))
        {
            UserId = userId;
            Email = email;
        }

        /// <summary>
        /// Convert the event to string
        /// </summary>
        /// <returns>The converted string</returns>
        public override string ToString()
        {
            return $"{FiredOn} - {UserId} email changed in {Email}";
        }
    }
}
