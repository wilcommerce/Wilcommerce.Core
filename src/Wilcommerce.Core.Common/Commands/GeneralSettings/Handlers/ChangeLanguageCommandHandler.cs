using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    public class ChangeLanguageCommandHandler : Interfaces.IChangeLanguageCommandHandler
    {
        public IRepository Repository { get; }

        public ChangeLanguageCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(ChangeLanguageCommand command)
        {
            try
            {
                var settings = await Repository.GetByKeyAsync<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.CurrentLanguage = command.Language;

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
