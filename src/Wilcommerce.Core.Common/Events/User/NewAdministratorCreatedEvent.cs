using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    /// <summary>
    /// New administrator created
    /// </summary>
    public class NewAdministratorCreatedEvent : DomainEvent
    {
        /// <summary>
        /// Get the administrator id
        /// </summary>
        public Guid AdministratorId { get; private set; }

        /// <summary>
        /// Get the administrator name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Get the administrator email
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Construct the event
        /// </summary>
        /// <param name="administratorId">The administrator id</param>
        /// <param name="name">The administrator name</param>
        /// <param name="email">The administrator email</param>
        public NewAdministratorCreatedEvent(Guid administratorId, string name, string email)
            : base(administratorId, typeof(Domain.Models.User))
        {
            AdministratorId = administratorId;
            Name = name;
            Email = email;
        }

        /// <summary>
        /// Convert the event to string
        /// </summary>
        /// <returns>The converted string</returns>
        public override string ToString()
        {
            return $"{FiredOn} - The administrator {Name}, {Email} [{AdministratorId}] was created";
        }
    }
}
