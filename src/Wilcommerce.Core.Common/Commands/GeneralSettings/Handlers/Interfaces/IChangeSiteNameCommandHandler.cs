using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers.Interfaces
{
    /// <summary>
    /// Handles the change of the site name
    /// </summary>
    public interface IChangeSiteNameCommandHandler : ICommandHandlerAsync<ChangeSiteNameCommand>
    {
    }
}
