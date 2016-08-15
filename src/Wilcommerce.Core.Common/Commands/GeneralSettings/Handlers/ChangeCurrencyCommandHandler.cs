using System;
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
                var settings = Repository.GetByKey<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.CurrentCurrency = command.Currency;

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
