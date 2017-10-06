using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    /// <summary>
    /// Change the user name
    /// </summary>
    public class ChangeUserNameCommand : ICommand
    {
        /// <summary>
        /// Get the user id
        /// </summary>
        public Guid UserId { get; }

        /// <summary>
        /// Get the new name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="userId">The user id</param>
        /// <param name="name">The new name</param>
        public ChangeUserNameCommand(Guid userId, string name)
        {
            UserId = userId;
            Name = name;
        }
    }
}
