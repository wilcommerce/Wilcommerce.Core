using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    public class DisableSiteCommand : ICommand
    {
        public Guid SettingsId { get; }

        public string Message { get; }

        public DisableSiteCommand(Guid settingsId, string message)
        {
            SettingsId = settingsId;
            Message = message;
        }
    }
}
