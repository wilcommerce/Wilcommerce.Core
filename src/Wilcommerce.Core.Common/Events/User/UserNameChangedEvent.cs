using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserNameChangedEvent : DomainEvent
    {
        public Guid UserId { get; private set; }

        public string Name { get; private set; }

        public UserNameChangedEvent(Guid userId, string name)
            : base(userId, typeof(Domain.Models.User))
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
