using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserEmailChangedEvent : DomainEvent
    {
        public Guid UserId { get; }

        public string Email { get; }

        public UserEmailChangedEvent(Guid userId, string email)
            : base()
        {
            UserId = userId;
            Email = email;
        }

        public override string ToString()
        {
            return $"{FiredOn} - {UserId} email changed in {Email}";
        }
    }
}
