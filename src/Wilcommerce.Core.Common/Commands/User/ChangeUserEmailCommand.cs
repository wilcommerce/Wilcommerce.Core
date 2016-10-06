using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    public class ChangeUserEmailCommand : ICommand
    {
        public Guid UserId { get; }

        public string Email { get; }

        public ChangeUserEmailCommand(Guid userId, string email)
        {
            UserId = userId;
            Email = email;
        }
    }
}
