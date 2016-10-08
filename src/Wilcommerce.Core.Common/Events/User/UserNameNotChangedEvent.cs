using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserNameNotChangedEvent : DomainEvent
    {
        public Guid UserId { get; }

        public string Name { get; }

        public string Error { get; }

        public UserNameNotChangedEvent(Guid userId, string name, string error)
            : base()
        {
            UserId = userId;
            Name = name;
            Error = error;
        }

        public override string ToString()
        {
            return $"{FiredOn} - {Error} while changing name to {Name} for user {UserId}";
        }
    }
}
