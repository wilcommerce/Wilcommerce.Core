using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserEnabledEvent : DomainEvent
    {
        public Guid UserId { get; private set; }

        public UserEnabledEvent(Guid userId)
            : base(userId, typeof(Domain.Models.User))
        {
            UserId = userId;
        }

        public override string ToString()
        {
            return $"{FiredOn} - User {UserId} enabled";
        }
    }
}
