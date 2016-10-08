using System;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;
using Wilcommerce.Core.Common.Events.User;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    public class ChangeUserEmailCommandHandler : Interfaces.IChangeUserEmailCommandHandler
    {
        public IRepository Repository { get; }

        public Infrastructure.IEventBus EventBus { get; }

        public ChangeUserEmailCommandHandler(IRepository repository, Infrastructure.IEventBus eventBus)
        {
            Repository = repository;
            EventBus = eventBus;
        }

        public async Task Handle(ChangeUserEmailCommand command)
        {
            try
            {
                var user = await Repository.GetByKeyAsync<Domain.Models.User>(command.UserId);
                user.ChangeEmail(command.Email);

                await Repository.SaveChangesAsync();

                var @event = new UserEmailChangedEvent(command.UserId, command.Email);
                EventBus.RaiseEvent(@event);
            }
            catch (Exception ex)
            {
                var @event = new UserEmailNotChangedEvent(command.UserId, command.Email, ex.Message);
                EventBus.RaiseEvent(@event);

                throw;
            }
        }
    }
}
