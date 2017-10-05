using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;
using Wilcommerce.Core.Common.Events.User;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    /// <summary>
    /// Handles the disabling of the user
    /// </summary>
    public class DisableUserCommandHandler : Interfaces.IDisableUserCommandHandler
    {
        /// <summary>
        /// Get the  repository instance
        /// </summary>
        public IRepository Repository { get; }

        /// <summary>
        /// Get the event bus instance
        /// </summary>
        public Infrastructure.IEventBus EventBus { get; }

        /// <summary>
        /// Construct the command handler
        /// </summary>
        /// <param name="repository">The repository</param>
        /// <param name="eventBus">The event bus</param>
        public DisableUserCommandHandler(IRepository repository, Infrastructure.IEventBus eventBus)
        {
            Repository = repository;
            EventBus = eventBus;
        }

        /// <summary>
        /// Disable the user
        /// </summary>
        /// <param name="command">The command to execute</param>
        /// <returns></returns>
        public async Task Handle(DisableUserCommand command)
        {
            try
            {
                var user = await Repository.GetByKeyAsync<Domain.Models.User>(command.UserId);
                user.Disable();

                await Repository.SaveChangesAsync();

                var @event = new UserDisabledEvent(command.UserId);
                EventBus.RaiseEvent(@event);
            }
            catch
            {
                throw;
            }
        }
    }
}
