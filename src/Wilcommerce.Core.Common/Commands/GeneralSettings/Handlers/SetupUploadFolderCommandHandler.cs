using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    public class SetupUploadFolderCommandHandler : Interfaces.ISetupUploadFolderCommandHandler
    {
        public IRepository Repository { get; }

        public SetupUploadFolderCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(SetupUploadFolderCommand command)
        {
            try
            {
                var settings = await Repository.GetByKeyAsync<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.SetUploadFolder(command.UploadFolder);

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
