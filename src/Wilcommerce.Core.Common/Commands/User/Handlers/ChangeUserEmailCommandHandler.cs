using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    public class ChangeUserEmailCommandHandler : Interfaces.IChangeUserEmailCommandHandler
    {
        public IRepository Repository { get; }

        public ChangeUserEmailCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(ChangeUserEmailCommand command)
        {
            try
            {
                var user = await Repository.GetByKeyAsync<Domain.Models.User>(command.UserId);
                user.ChangeEmail(command.Email);

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
