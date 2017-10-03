using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class NewAdministratorCreatedEvent : DomainEvent
    {
        public Guid AdministratorId { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public NewAdministratorCreatedEvent(Guid administratorId, string name, string email)
            : base(administratorId, typeof(Domain.Models.User))
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
