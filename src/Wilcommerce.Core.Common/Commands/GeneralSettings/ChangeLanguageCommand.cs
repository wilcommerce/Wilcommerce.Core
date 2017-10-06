using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    /// <summary>
    /// Change the system's language
    /// </summary>
    public class ChangeLanguageCommand : ICommand
    {
        /// <summary>
        /// The settings id
        /// </summary>
        public Guid SettingsId { get; }

        /// <summary>
        /// The new language
        /// </summary>
        public string Language { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="language">The new language</param>
        public ChangeLanguageCommand(Guid settingsId, string language)
        {
            SettingsId = settingsId;
            Language = language;
        }
    }
}
