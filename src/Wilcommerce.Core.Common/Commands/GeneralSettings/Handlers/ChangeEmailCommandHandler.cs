using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers
{
    public class ChangeEmailCommandHandler : Interfaces.IChangeEmailCommandHandler
    {
        public IRepository Repository { get; }

        public ChangeEmailCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(ChangeEmailCommand command)
        {
            try
            {
                var settings = await Repository.GetByKeyAsync<Domain.Models.GeneralSettings>(command.SettingsId);
                settings.ChangeEmail(command.Email);

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
