using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    public class SetupSettingsCommandHandler : Interfaces.ISetupSettingsCommandHandler
    {
        public IRepository Repository { get; }

        public SetupSettingsCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

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
