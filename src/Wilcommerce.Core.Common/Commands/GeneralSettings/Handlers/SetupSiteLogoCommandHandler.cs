using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    public class SetupSiteLogoCommandHandler : Interfaces.ISetupSiteLogoCommandHandler
    {
        public IRepository Repository { get; }

        public SetupSiteLogoCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(SetupSiteLogoCommand command)
        {
            try
            {
                var settings = await Repository.GetByKeyAsync<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.SetSiteLogo(command.SiteLogo);

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
