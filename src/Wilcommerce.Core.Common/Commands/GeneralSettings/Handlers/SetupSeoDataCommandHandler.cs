using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    /// <see cref="Interfaces.ISetupSeoDataCommandHandler"/>
    public class SetupSeoDataCommandHandler : Interfaces.ISetupSeoDataCommandHandler
    {
        /// <summary>
        /// Get the repository instance
        /// </summary>
        public IRepository Repository { get; }

        /// <summary>
        /// Construct the command handler
        /// </summary>
        /// <param name="repository">The repository</param>
        public SetupSeoDataCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        /// <summary>
        /// Setup the SEO data
        /// </summary>
        /// <param name="command">The command to execute</param>
        /// <returns></returns>
        public async Task Handle(SetupSeoDataCommand command)
        {
            try
            {
                var settings = await Repository.GetByKeyAsync<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.SetSeoData(command.Seo);

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
