using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    public class ChangeSiteNameCommand : ICommand
    {
        public Guid SettingsId { get; }

        public string SiteName { get; }

        public ChangeSiteNameCommand(Guid settingsId, string siteName)
        {
            SettingsId = settingsId;
            SiteName = siteName;
        }
    }
}
