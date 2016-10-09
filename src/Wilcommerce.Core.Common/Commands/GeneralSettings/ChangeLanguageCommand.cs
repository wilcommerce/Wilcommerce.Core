using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    public class ChangeLanguageCommand : ICommand
    {
        public Guid SettingsId { get; }

        public string Language { get; }

        public ChangeLanguageCommand(Guid settingsId, string language)
        {
            SettingsId = settingsId;
            Language = language;
        }
    }
}
