using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    public class ChangeCurrencyCommand : ICommand
    {
        public Guid SettingsId { get; }

        public string Currency { get; }

        public ChangeCurrencyCommand(Guid settingsId, string currency)
        {
            SettingsId = settingsId;
            Currency = currency;
        }
    }
}
