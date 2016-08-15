using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    public class SetupSettingsCommand : ICommand
    {
        public string SiteName { get; }

        public string Language { get; }

        public string Currency { get; }

        public string Email { get; }

        public SetupSettingsCommand(string siteName, string language, string currency, string email)
        {
            SiteName = siteName;
            Language = language;
            Currency = currency;
            Email = email;
        }
    }
}
