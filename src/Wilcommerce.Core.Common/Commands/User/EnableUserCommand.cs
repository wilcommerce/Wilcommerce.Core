using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    public class EnableUserCommand : ICommand
    {
        public Guid UserId { get; }

        public EnableUserCommand(Guid userId)
        {
            UserId = UserId;
        }
    }
}
