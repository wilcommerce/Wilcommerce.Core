using System;
using Wilcommerce.Core.Common.Domain.Models;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    /// <summary>
    /// Setup the site logo
    /// </summary>
    public class SetupSiteLogoCommand : ICommand
    {
        /// <summary>
        /// Get the settings id
        /// </summary>
        public Guid SettingsId { get; }

        /// <summary>
        /// Get the site logo
        /// </summary>
        public Image SiteLogo { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="siteLogo">The site logo</param>
        public SetupSiteLogoCommand(Guid settingsId, Image siteLogo)
        {
            SettingsId = settingsId;
            SiteLogo = siteLogo;
        }
    }
}
