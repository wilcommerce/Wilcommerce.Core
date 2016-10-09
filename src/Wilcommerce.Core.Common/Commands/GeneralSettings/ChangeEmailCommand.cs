using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    public class ChangeEmailCommand : ICommand
    {
        public Guid SettingsId { get; }

        public string Email { get; }

        public ChangeEmailCommand(Guid settingsId, string email)
        {
            SettingsId = settingsId;
            Email = email;
        }
    }
}
