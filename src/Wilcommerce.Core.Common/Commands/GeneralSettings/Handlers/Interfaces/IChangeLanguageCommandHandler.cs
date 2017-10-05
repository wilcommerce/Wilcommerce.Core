using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers.Interfaces
{
    /// <summary>
    /// Handles the change of the language
    /// </summary>
    public interface IChangeLanguageCommandHandler : ICommandHandlerAsync<ChangeLanguageCommand>
    {
    }
}
