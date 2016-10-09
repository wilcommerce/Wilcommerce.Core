using System;
using Wilcommerce.Core.Common.Domain.Models;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    public class SetupSiteLogoCommand : ICommand
    {
        public Guid SettingsId { get; }

        public Image SiteLogo { get; }

        public SetupSiteLogoCommand(Guid settingsId, Image siteLogo)
        {
            SettingsId = settingsId;
            SiteLogo = siteLogo;
        }
    }
}
