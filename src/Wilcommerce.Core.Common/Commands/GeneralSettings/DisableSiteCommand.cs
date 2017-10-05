using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    /// <summary>
    /// Disable the site
    /// </summary>
    public class DisableSiteCommand : ICommand
    {
        /// <summary>
        /// Get the settings id
        /// </summary>
        public Guid SettingsId { get; }

        /// <summary>
        /// Get the message to show
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="message">The message to show</param>
        public DisableSiteCommand(Guid settingsId, string message)
        {
            SettingsId = settingsId;
            Message = message;
        }
    }
}
