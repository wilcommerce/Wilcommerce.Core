using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    public class SetUserProfileCommandHandler : Interfaces.ISetUserProfileCommandHandler
    {
        public IRepository Repository { get; }

        public SetUserProfileCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(SetUserProfileCommand command)
        {
            try
            {
                var user = await Repository.GetByKeyAsync<Domain.Models.User>(command.UserId);
                user.SetProfileImage(command.ProfileImage);

                await Repository.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
