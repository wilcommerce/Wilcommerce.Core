using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserPasswordNotChangedEvent : DomainEvent
    {
        public Guid UserId { get; }

        public string Error { get; }

        public UserPasswordNotChangedEvent(Guid userId, string error)
            : base()
        {
            UserId = userId;
            Error = error;
        }

        public override string ToString()
        {
            return $"{FiredOn} - {Error} while changing password for user {UserId}";
        }
    }
}
