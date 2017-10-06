using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    /// <summary>
    /// Disable the user
    /// </summary>
    public class DisableUserCommand : ICommand
    {
        /// <summary>
        /// Get the user id
        /// </summary>
        public Guid UserId { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="userId">The user id</param>
        public DisableUserCommand(Guid userId)
        {
            UserId = UserId;
        }
    }
}
