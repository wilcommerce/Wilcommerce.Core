using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User.Handlers.Interfaces
{
    /// <summary>
    /// Handles the creation of a new administrator
    /// </summary>
    public interface ICreateNewAdministratorCommandHandler : ICommandHandlerAsync<CreateNewAdministratorCommand>
    {
    }
}
