using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserDisabledEvent : DomainEvent
    {
        public Guid UserId { get; }

        public UserDisabledEvent(Guid userId)
            : base(userId, typeof(Domain.Models.User))
        {
            UserId = userId;
        }

        public override string ToString()
        {
            return $"{FiredOn} - User {UserId} disabled";
        }
    }
}
