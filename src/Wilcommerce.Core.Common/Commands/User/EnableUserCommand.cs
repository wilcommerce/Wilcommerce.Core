using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    /// <summary>
    /// Enable the user
    /// </summary>
    public class EnableUserCommand : ICommand
    {
        /// <summary>
        /// Get the user id
        /// </summary>
        public Guid UserId { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="userId">The user id</param>
        public EnableUserCommand(Guid userId)
        {
            UserId = UserId;
        }
    }
}
