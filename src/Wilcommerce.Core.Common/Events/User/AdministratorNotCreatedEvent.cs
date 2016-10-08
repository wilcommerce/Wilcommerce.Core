using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class AdministratorNotCreatedEvent : DomainEvent
    {
        public string Name { get; }

        public string Email { get; }

        public string Error { get; }

        public AdministratorNotCreatedEvent(string name, string email, string error)
            : base()
        {
            Name = name;
            Email = email;
            Error = error;
        }

        public override string ToString()
        {
            return $"{FiredOn} - {Error} while creating administrator {Name}, {Email}";
        }
    }
}
