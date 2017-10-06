using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User.Handlers.Interfaces
{
    /// <summary>
    /// Handles the change of the user name
    /// </summary>
    public interface IChangeUserNameCommandHandler : ICommandHandlerAsync<ChangeUserNameCommand>
    {
    }
}
