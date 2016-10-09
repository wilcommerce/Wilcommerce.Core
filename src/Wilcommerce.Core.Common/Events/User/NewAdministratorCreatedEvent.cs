using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class NewAdministratorCreatedEvent : DomainEvent
    {
        public Guid AdministratorId { get; }

        public string Name { get; }

        public string Email { get; }

        public NewAdministratorCreatedEvent(Guid administratorId, string name, string email)
            : base()
        {
            AdministratorId = administratorId;
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{FiredOn} - The administrator {Name}, {Email} [{AdministratorId}] was created";
        }
    }
}
