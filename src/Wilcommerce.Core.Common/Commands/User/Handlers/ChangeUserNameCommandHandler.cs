using System;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;
using Wilcommerce.Core.Common.Events.User;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    public class ChangeUserNameCommandHandler : Interfaces.IChangeUserNameCommandHandler
    {
        public IRepository Repository { get; }

        public Infrastructure.IEventBus EventBus { get; }

        public ChangeUserNameCommandHandler(IRepository repository, Infrastructure.IEventBus eventBus)
        {
            Repository = repository;
            EventBus = eventBus;
        }

        public async Task Handle(ChangeUserNameCommand command)
        {
            try
            {
                var user = await Repository.GetByKeyAsync<Domain.Models.User>(command.UserId);
                user.ChangeName(command.Name);

                await Repository.SaveChangesAsync();

                var @event = new UserNameChangedEvent(command.UserId, command.Name);
                EventBus.RaiseEvent(@event);
            }
            catch (Exception ex)
            {
                var @event = new UserNameNotChangedEvent(command.UserId, command.Name, ex.Message);
                EventBus.RaiseEvent(@event);

                throw;
            }
        }
    }
}
