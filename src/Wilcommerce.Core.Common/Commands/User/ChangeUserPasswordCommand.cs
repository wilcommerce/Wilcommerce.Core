using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    /// <summary>
    /// Change the user password
    /// </summary>
    public class ChangeUserPasswordCommand : ICommand
    {
        /// <summary>
        /// Get the user id
        /// </summary>
        public Guid UserId { get; }

        /// <summary>
        /// Get the new password
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="userId">The user id</param>
        /// <param name="password">The new password</param>
        public ChangeUserPasswordCommand(Guid userId, string password)
        {
            UserId = userId;
            Password = password;
        }
    }
}
