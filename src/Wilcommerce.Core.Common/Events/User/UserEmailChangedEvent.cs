using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserEmailChangedEvent : DomainEvent
    {
        public Guid UserId { get; private set; }

        public string Email { get; private set; }

        public UserEmailChangedEvent(Guid userId, string email)
            : base(userId, typeof(Domain.Models.User))
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
