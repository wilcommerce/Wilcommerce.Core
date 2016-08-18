using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    public class EnableSiteCommandHandler : Interfaces.IEnableSiteCommandHandler
    {
        public IRepository Repository { get; }

        public EnableSiteCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(EnableSiteCommand command)
        {
            try
            {
                var settings = await Repository.GetByKeyAsync<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.EnableSite();

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
