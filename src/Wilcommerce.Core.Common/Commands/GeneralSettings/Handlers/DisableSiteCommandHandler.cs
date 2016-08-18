using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    public class DisableSiteCommandHandler : Interfaces.IDisableSiteCommandHandler
    {
        public IRepository Repository { get; }

        public DisableSiteCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

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
