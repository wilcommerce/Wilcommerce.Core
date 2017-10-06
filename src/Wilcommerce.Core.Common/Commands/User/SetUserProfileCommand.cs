using System;
using Wilcommerce.Core.Common.Domain.Models;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    /// <summary>
    /// Set the user profile image
    /// </summary>
    public class SetUserProfileCommand : ICommand
    {
        /// <summary>
        /// Get the user id
        /// </summary>
        public Guid UserId { get; }

        /// <summary>
        /// Get the profile image
        /// </summary>
        public Image ProfileImage { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="userId">The user id</param>
        /// <param name="profileImage">The profile image</param>
        public SetUserProfileCommand(Guid userId, Image profileImage)
        {
            UserId = userId;
            ProfileImage = profileImage;
        }
    }
}
