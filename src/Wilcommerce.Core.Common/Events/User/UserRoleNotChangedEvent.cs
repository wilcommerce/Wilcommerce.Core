using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserRoleNotChangedEvent : DomainEvent
    {
        public Guid UserId { get; }

        public Domain.Models.User.Roles Role { get; }

        public string Error { get; }

        public UserRoleNotChangedEvent(Guid userId, Domain.Models.User.Roles role, string error)
            : base()
        {
            UserId = userId;
            Role = role;
            Error = error;
        }

        public override string ToString()
        {
            return $"{FiredOn} - {Error} while changing the role to {Role} for user {UserId}";
        }
    }
}
