using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User.Handlers.Interfaces
{
    /// <summary>
    /// Handles the change of the user role
    /// </summary>
    public interface IChangeUserRoleCommandHandler : ICommandHandlerAsync<ChangeUserRoleCommand>
    {
    }
}
