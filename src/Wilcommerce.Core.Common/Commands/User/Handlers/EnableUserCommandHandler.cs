using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    public class EnableUserCommandHandler : Interfaces.IEnableUserCommandHandler
    {
        public IRepository Repository { get; }

        public EnableUserCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(EnableUserCommand command)
        {
            try
            {
                var user = await Repository.GetByKeyAsync<Domain.Models.User>(command.UserId);
                user.Disable();

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
