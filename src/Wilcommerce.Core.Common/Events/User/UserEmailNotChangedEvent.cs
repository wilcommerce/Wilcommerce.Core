using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserEmailNotChangedEvent : DomainEvent
    {
        public Guid UserId { get; }

        public string Email { get; }

        public string Error { get; }

        public UserEmailNotChangedEvent(Guid userId, string email, string error)
            : base()
        {
            UserId = userId;
            Email = email;
            Error = error;
        }

        public override string ToString()
        {
            return $"{FiredOn} - {Error} while changing the email for {UserId} to {Email}";
        }
    }
}
