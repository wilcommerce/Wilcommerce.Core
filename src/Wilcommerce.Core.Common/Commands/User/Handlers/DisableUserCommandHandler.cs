using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;
using Wilcommerce.Core.Common.Events.User;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    public class DisableUserCommandHandler : Interfaces.IDisableUserCommandHandler
    {
        public IRepository Repository { get; }

        public Infrastructure.IEventBus EventBus { get; }

        public DisableUserCommandHandler(IRepository repository, Infrastructure.IEventBus eventBus)
        {
            Repository = repository;
            EventBus = eventBus;
        }

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
