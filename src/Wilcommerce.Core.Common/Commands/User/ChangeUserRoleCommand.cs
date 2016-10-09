using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    public class ChangeUserRoleCommand : ICommand
    {
        public Guid UserId { get; }

        public Domain.Models.User.Roles Role { get; }

        public ChangeUserRoleCommand(Guid userId, Domain.Models.User.Roles role)
        {
            UserId = userId;
            Role = role;
        }
    }
}
