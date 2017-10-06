using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    /// <summary>
    /// Change the system's email
    /// </summary>
    public class ChangeEmailCommand : ICommand
    {
        /// <summary>
        /// The settings id
        /// </summary>
        public Guid SettingsId { get; }

        /// <summary>
        /// The new email
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="email">The new email</param>
        public ChangeEmailCommand(Guid settingsId, string email)
        {
            SettingsId = settingsId;
            Email = email;
        }
    }
}
