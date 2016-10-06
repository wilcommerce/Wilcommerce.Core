using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    public class ChangeUserRoleCommandHandler : Interfaces.IChangeUserRoleCommandHandler
    {
        public IRepository Repository { get; }

        public ChangeUserRoleCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(ChangeUserRoleCommand command)
        {
            try
            {
                var user = await Repository.GetByKeyAsync<Domain.Models.User>(command.UserId);
                user.ChangeRole(command.Role);

                await Repository.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
