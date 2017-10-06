using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers.Interfaces
{
    /// <summary>
    /// Handles the change of the system email
    /// </summary>
    public interface IChangeEmailCommandHandler : ICommandHandlerAsync<ChangeEmailCommand>
    {
    }
}
