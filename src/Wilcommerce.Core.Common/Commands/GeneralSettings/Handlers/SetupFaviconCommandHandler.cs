using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    /// <see cref="Interfaces.ISetupFaviconCommandHandler"/>
    public class SetupFaviconCommandHandler : Interfaces.ISetupFaviconCommandHandler
    {
        /// <summary>
        /// Get the repository instance
        /// </summary>
        public IRepository Repository { get; }

        /// <summary>
        /// Construct the command handler
        /// </summary>
        /// <param name="repository">The repository</param>
        public SetupFaviconCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        /// <summary>
        /// Setup the favicon
        /// </summary>
        /// <param name="command">The command to execute</param>
        /// <returns></returns>
        public async Task Handle(SetupFaviconCommand command)
        {
            try
            {
                var settings = await Repository.GetByKeyAsync<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.SetFavicon(command.Favicon);

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
