using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserNameChangedEvent : DomainEvent
    {
        public Guid UserId { get; }

        public string Name { get; }

        public UserNameChangedEvent(Guid userId, string name)
            : base()
        {
            UserId = userId;
            Name = name;
        }

        public override string ToString()
        {
            return $"{FiredOn} - Name changed to {Name} for user {UserId}";
        }
    }
}
