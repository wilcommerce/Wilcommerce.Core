using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserProfileImageNotChangedEvent : DomainEvent
    {
        public Guid UserId { get; }

        public string Error { get; }

        public UserProfileImageNotChangedEvent(Guid userId, string error)
            : base()
        {
            UserId = userId;
            Error = error;
        }

        public override string ToString()
        {
            return $"{FiredOn} - {Error} while changing profile image for user {UserId}";
        }
    }
}
