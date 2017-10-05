using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;
using Wilcommerce.Core.Common.Events.User;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    /// <see cref="Interfaces.ISetUserProfileCommandHandler"/>
    public class SetUserProfileCommandHandler : Interfaces.ISetUserProfileCommandHandler
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
        /// Construct the command handler
        /// </summary>
        /// <param name="repository">The repository</param>
        /// <param name="eventBus">The event bus</param>
        public SetUserProfileCommandHandler(IRepository repository, Infrastructure.IEventBus eventBus)
        {
            Repository = repository;
            EventBus = eventBus;
        }

        /// <summary>
        /// Set the user profile image
        /// </summary>
        /// <param name="command">The command to execute</param>
        /// <returns></returns>
        public async Task Handle(SetUserProfileCommand command)
        {
            try
            {
                var user = await Repository.GetByKeyAsync<Domain.Models.User>(command.UserId);
                user.SetProfileImage(command.ProfileImage);

                await Repository.SaveChangesAsync();

                var @event = new UserProfileImageChangedEvent(command.UserId);
                EventBus.RaiseEvent(@event);
            }
            catch 
            {
                throw;
            }
        }
    }
}
