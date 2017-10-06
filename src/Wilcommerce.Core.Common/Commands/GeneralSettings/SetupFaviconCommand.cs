using System;
using Wilcommerce.Core.Common.Domain.Models;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    /// <summary>
    /// Setup the favicon
    /// </summary>
    public class SetupFaviconCommand : ICommand
    {
        /// <summary>
        /// Get the settings id
        /// </summary>
        public Guid SettingsId { get; }

        /// <summary>
        /// Get the favicon
        /// </summary>
        public Image Favicon { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="favicon">The favicon image</param>
        public SetupFaviconCommand(Guid settingsId, Image favicon)
        {
            SettingsId = settingsId;
            Favicon = favicon;
        }
    }
}
