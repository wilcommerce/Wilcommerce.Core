using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserRoleChangedEvent : DomainEvent
    {
        public Guid UserId { get; }

        public Domain.Models.User.Roles Role { get; }

        public UserRoleChangedEvent(Guid userId, Domain.Models.User.Roles role)
            : base()
        {
            UserId = userId;
            Role = role;
        }

        public override string ToString()
        {
            return $"{FiredOn} - The user {UserId} changed the role to {Role}";
        }
    }
}
