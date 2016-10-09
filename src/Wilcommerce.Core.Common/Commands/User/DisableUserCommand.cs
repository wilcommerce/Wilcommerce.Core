using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    public class DisableUserCommand : ICommand
    {
        public Guid UserId { get; }

        public DisableUserCommand(Guid userId)
        {
            UserId = UserId;
        }
    }
}
