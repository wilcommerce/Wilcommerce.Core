using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User.Handlers.Interfaces
{
    /// <summary>
    /// Handles the disabling of the user
    /// </summary>
    public interface IDisableUserCommandHandler : ICommandHandlerAsync<DisableUserCommand>
    {
    }
}
