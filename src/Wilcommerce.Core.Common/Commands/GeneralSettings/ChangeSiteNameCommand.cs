using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    /// <summary>
    /// Change the site name
    /// </summary>
    public class ChangeSiteNameCommand : ICommand
    {
        /// <summary>
        /// Get the settings id
        /// </summary>
        public Guid SettingsId { get; }

        /// <summary>
        /// The site name
        /// </summary>
        public string SiteName { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="siteName">The site name</param>
        public ChangeSiteNameCommand(Guid settingsId, string siteName)
        {
            SettingsId = settingsId;
            SiteName = siteName;
        }
    }
}
