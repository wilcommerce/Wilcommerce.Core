using System;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;
using Wilcommerce.Core.Common.Events.User;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    public class ChangeUserRoleCommandHandler : Interfaces.IChangeUserRoleCommandHandler
    {
        public IRepository Repository { get; }

        public Infrastructure.IEventBus EventBus { get; }

        public ChangeUserRoleCommandHandler(IRepository repository, Infrastructure.IEventBus eventBus)
        {
            Repository = repository;
            EventBus = eventBus;
        }

        public async Task Handle(ChangeUserRoleCommand command)
        {
            try
            {
                var user = await Repository.GetByKeyAsync<Domain.Models.User>(command.UserId);
                user.ChangeRole(command.Role);

                await Repository.SaveChangesAsync();

                var @event = new UserRoleChangedEvent(command.UserId, command.Role);
                EventBus.RaiseEvent(@event);
            }
            catch (Exception ex)
            {
                var @event = new UserRoleNotChangedEvent(command.UserId, command.Role, ex.Message);
                EventBus.RaiseEvent(@event);

                throw;
            }
        }
    }
}
