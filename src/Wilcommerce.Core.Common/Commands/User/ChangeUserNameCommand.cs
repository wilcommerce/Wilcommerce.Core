using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    public class ChangeUserNameCommand : ICommand
    {
        public Guid UserId { get; }

        public string Name { get; }

        public ChangeUserNameCommand(Guid userId, string name)
        {
            UserId = userId;
            Name = name;
        }
    }
}
