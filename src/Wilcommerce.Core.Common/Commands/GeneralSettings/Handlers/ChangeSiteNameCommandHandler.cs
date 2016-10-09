using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    public class ChangeSiteNameCommandHandler : Interfaces.IChangeSiteNameCommandHandler
    {
        public IRepository Repository { get; }

        public ChangeSiteNameCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(ChangeSiteNameCommand command)
        {
            try
            {
                var settings = await Repository.GetByKeyAsync<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.ChangeSiteName(command.SiteName);

                await Repository.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
