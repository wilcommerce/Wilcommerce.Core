using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;
using Wilcommerce.Core.Common.Events.User;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    public class CreateNewAdministratorCommandHandler : Interfaces.ICreateNewAdministratorCommandHandler
    {
        public IRepository Repository { get; }

        public Infrastructure.IEventBus EventBus { get; }

        public CreateNewAdministratorCommandHandler(IRepository repository, Infrastructure.IEventBus eventBus)
        {
            Repository = repository;
            EventBus = eventBus;
        }

        public async Task Handle(CreateNewAdministratorCommand command)
        {
            try
            {
                var administrator = Domain.Models.User.CreateAsAdministrator(
                    command.Name,
                    command.Email,
                    command.Password
                    );

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
