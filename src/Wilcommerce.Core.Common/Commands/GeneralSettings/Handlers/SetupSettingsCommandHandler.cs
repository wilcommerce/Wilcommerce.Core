using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    /// <see cref="Interfaces.ISetupSettingsCommandHandler"/>
    public class SetupSettingsCommandHandler : Interfaces.ISetupSettingsCommandHandler
    {
        /// <summary>
        /// Get the repository instance
        /// </summary>
        public IRepository Repository { get; }

        /// <summary>
        /// Construct the command handler
        /// </summary>
        /// <param name="repository">The repository</param>
        public SetupSettingsCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        /// <summary>
        /// Setup the general settings
        /// </summary>
        /// <param name="command">The command to execute</param>
        /// <returns></returns>
        public async Task Handle(SetupSettingsCommand command)
        {
            try
            {
                var settings = Domain.Models.GeneralSettings.Create(
                    command.SiteName,
                    command.Language,
                    command.Currency,
                    command.Email
                    );

                Repository.Add(settings);

                await Repository.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
