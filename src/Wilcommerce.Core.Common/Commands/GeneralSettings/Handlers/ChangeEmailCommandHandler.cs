using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    /// <see cref="Interfaces.IChangeEmailCommandHandler"/>
    public class ChangeEmailCommandHandler : Interfaces.IChangeEmailCommandHandler
    {
        /// <summary>
        /// Get the repository instance
        /// </summary>
        public IRepository Repository { get; }

        /// <summary>
        /// Construct the command handler
        /// </summary>
        /// <param name="repository">The repository</param>
        public ChangeEmailCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        /// <summary>
        /// Change the system's email
        /// </summary>
        /// <param name="command">The command to execute</param>
        /// <returns></returns>
        public async Task Handle(ChangeEmailCommand command)
        {
            try
            {
                var settings = await Repository.GetByKeyAsync<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.ChangeEmail(command.Email);

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
