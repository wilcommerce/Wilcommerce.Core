using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserPasswordChangedEvent : DomainEvent
    {
        public Guid UserId { get; private set; }

        public UserPasswordChangedEvent(Guid userId)
            : base(userId, typeof(Domain.Models.User))
        {
            UserId = userId;
        }

        public override string ToString()
        {
            return $"{FiredOn} - Password changed for user {UserId}";
        }
    }
}
