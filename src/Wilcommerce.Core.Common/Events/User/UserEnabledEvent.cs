﻿using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserEnabledEvent : DomainEvent
    {
        public Guid UserId { get; }

        public UserEnabledEvent(Guid userId)
            : base()
        {
            UserId = userId;
        }

        public override string ToString()
        {
            return $"{FiredOn} - User {UserId} enabled";
        }
    }
}
