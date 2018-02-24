using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;
using Wilcommerce.Core.Common.Events.User;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    /// <see cref="Interfaces.ICreateNewAdministratorCommandHandler"/>
    public class CreateNewAdministratorCommandHandler : Interfaces.ICreateNewAdministratorCommandHandler
    {
        /// <summary>
        /// Get the repository instance
        /// </summary>
        public IRepository Repository { get; }

        /// <summary>
        /// Get the event bus instance
        /// </summary>
        public Infrastructure.IEventBus EventBus { get; }

        /// <summary>
        /// Get the password hasher service
        /// </summary>
        public IPasswordHasher<Domain.Models.User> PasswordHasher { get; }

        /// <summary>
        /// Construct the command handler
        /// </summary>
        /// <param name="repository">The repository</param>
        /// <param name="eventBus">The event bus</param>
        /// <param name="passwordHasher">The password hasher instance</param>
        public CreateNewAdministratorCommandHandler(IRepository repository, Infrastructure.IEventBus eventBus, IPasswordHasher<Domain.Models.User> passwordHasher)
        {
            Repository = repository;
            EventBus = eventBus;
            PasswordHasher = passwordHasher;
        }

        /// <summary>
        /// Create a new administrator
        /// </summary>
        /// <param name="command">The command to execute</param>
        /// <returns></returns>
        public async Task Handle(CreateNewAdministratorCommand command)
        {
            try
            {
                var administrator = Domain.Models.User.CreateAsAdministrator(
                    command.Name,
                    command.Email,
                    command.Password,
                    PasswordHasher);

                Repository.Add(administrator);
                await Repository.SaveChangesAsync();

                var @event = new NewAdministratorCreatedEvent(
                    administrator.Id,
                    administrator.Name,
                    administrator.Email
                    );

                EventBus.RaiseEvent(@event);
            }
            catch 
            {
                throw;
            }
        }
    }
}
