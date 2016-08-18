using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    public class ChangeCurrencyCommandHandler : Interfaces.IChangeCurrencyCommandHandler
    {
        public IRepository Repository { get; }

        public ChangeCurrencyCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(ChangeCurrencyCommand command)
        {
            try
            {
                var settings = await Repository.GetByKeyAsync<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.ChangeCurrency(command.Currency);

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
