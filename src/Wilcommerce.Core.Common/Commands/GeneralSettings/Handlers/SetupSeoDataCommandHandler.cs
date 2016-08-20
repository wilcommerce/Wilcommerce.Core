using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    public class SetupSeoDataCommandHandler : Interfaces.ISetupSeoDataCommandHandler
    {
        public IRepository Repository { get; }

        public SetupSeoDataCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

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
