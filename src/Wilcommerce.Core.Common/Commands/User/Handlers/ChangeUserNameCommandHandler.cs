using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    public class ChangeUserNameCommandHandler : Interfaces.IChangeUserNameCommandHandler
    {
        public IRepository Repository { get; }

        public ChangeUserNameCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(ChangeUserNameCommand command)
        {
            try
            {
                var user = await Repository.GetByKeyAsync<Domain.Models.User>(command.UserId);
                user.ChangeName(command.Name);

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
