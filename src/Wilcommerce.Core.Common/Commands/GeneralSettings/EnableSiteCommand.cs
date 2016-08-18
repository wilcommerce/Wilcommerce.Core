using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    public class EnableSiteCommand : ICommand
    {
        public Guid SettingsId { get; }

        public EnableSiteCommand(Guid settingsId)
        {

        }
    }
}
