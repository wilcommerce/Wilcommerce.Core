using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    public class SetupFaviconCommandHandler : Interfaces.ISetupFaviconCommandHandler
    {
        public IRepository Repository { get; }

        public SetupFaviconCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(SetupFaviconCommand command)
        {
            try
            {
                var settings = await Repository.GetByKeyAsync<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.Favicon = command.Favicon;

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
