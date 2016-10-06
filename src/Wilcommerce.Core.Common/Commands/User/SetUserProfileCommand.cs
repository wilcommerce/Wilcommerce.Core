using System;
using Wilcommerce.Core.Common.Domain.Models;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    public class SetUserProfileCommand : ICommand
    {
        public Guid UserId { get; }

        public Image ProfileImage { get; }

        public SetUserProfileCommand(Guid userId, Image profileImage)
        {
            UserId = userId;
            ProfileImage = profileImage;
        }
    }
}
