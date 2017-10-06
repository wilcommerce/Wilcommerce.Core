using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    /// <see cref="Interfaces.IDisableSiteCommandHandler"/>
    public class DisableSiteCommandHandler : Interfaces.IDisableSiteCommandHandler
    {
        /// <summary>
        /// Get the repository instance
        /// </summary>
        public IRepository Repository { get; }

        /// <summary>
        /// Construct the command handler
        /// </summary>
        /// <param name="repository">The repository</param>
        public DisableSiteCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        /// <summary>
        /// Disable the site
        /// </summary>
        /// <param name="command">The command to execute</param>
        /// <returns></returns>
        public async Task Handle(DisableSiteCommand command)
        {
            try
            {
                var settings = await Repository.GetByKeyAsync<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.DisableSite(command.Message);

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
