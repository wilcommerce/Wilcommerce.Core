using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    public class ChangeUserPasswordCommand : ICommand
    {
        public Guid UserId { get; }

        public string Password { get; }

        public ChangeUserPasswordCommand(Guid userId, string password)
        {
            UserId = userId;
            Password = password;
        }
    }
}
