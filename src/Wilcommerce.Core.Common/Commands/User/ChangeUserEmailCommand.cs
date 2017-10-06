using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    /// <summary>
    /// Change of the user email
    /// </summary>
    public class ChangeUserEmailCommand : ICommand
    {
        /// <summary>
        /// Get the user id
        /// </summary>
        public Guid UserId { get; }

        /// <summary>
        /// Get the new user email
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="userId">The user id</param>
        /// <param name="email">The user email</param>
        public ChangeUserEmailCommand(Guid userId, string email)
        {
            UserId = userId;
            Email = email;
        }
    }
}
