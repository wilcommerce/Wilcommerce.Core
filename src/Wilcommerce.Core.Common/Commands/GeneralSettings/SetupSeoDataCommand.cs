using System;
using Wilcommerce.Core.Common.Domain.Models;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    /// <summary>
    /// Setup the SEO data
    /// </summary>
    public class SetupSeoDataCommand : ICommand
    {
        /// <summary>
        /// Get the settings id
        /// </summary>
        public Guid SettingsId { get; }

        /// <summary>
        /// Get the SEO data
        /// </summary>
        public SeoData Seo { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="seo">The SEO data</param>
        public SetupSeoDataCommand(Guid settingsId, SeoData seo)
        {
            SettingsId = settingsId;
            Seo = seo;
        }
    }
}
