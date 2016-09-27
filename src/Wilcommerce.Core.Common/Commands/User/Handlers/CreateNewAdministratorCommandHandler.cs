using System;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    public class CreateNewAdministratorCommandHandler : Interfaces.ICreateNewAdministratorCommandHandler
    {
        public IRepository Repository { get; }

        public CreateNewAdministratorCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(CreateNewAdministratorCommand command)
        {
            try
            {
                var administrator = Domain.Models.User.CreateAsAdministrator(
                    command.Name,
                    command.Email,
                    command.Password
                    );

                Repository.Add(administrator);
                await Repository.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
