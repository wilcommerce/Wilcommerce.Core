using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    /// <summary>
    /// Change the user role
    /// </summary>
    public class ChangeUserRoleCommand : ICommand
    {
        /// <summary>
        /// Get the user id
        /// </summary>
        public Guid UserId { get; }

        /// <summary>
        /// Get the new role
        /// </summary>
        public Domain.Models.User.Roles Role { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="userId">The user id</param>
        /// <param name="role">The new role</param>
        public ChangeUserRoleCommand(Guid userId, Domain.Models.User.Roles role)
        {
            UserId = userId;
            Role = role;
        }
    }
}
