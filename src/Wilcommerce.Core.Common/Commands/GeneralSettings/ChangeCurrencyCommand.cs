using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    /// <summary>
    /// Change the system currency
    /// </summary>
    public class ChangeCurrencyCommand : ICommand
    {
        /// <summary>
        /// Get the settings id
        /// </summary>
        public Guid SettingsId { get; }

        /// <summary>
        /// Get the new currency
        /// </summary>
        public string Currency { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="currency">The new currency</param>
        public ChangeCurrencyCommand(Guid settingsId, string currency)
        {
            SettingsId = settingsId;
            Currency = currency;
        }
    }
}
