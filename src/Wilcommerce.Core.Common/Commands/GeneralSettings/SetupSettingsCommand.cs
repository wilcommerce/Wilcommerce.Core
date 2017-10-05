using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    /// <summary>
    /// Setup the general settings
    /// </summary>
    public class SetupSettingsCommand : ICommand
    {
        /// <summary>
        /// Get the site name
        /// </summary>
        public string SiteName { get; }

        /// <summary>
        /// Get the system's language
        /// </summary>
        public string Language { get; }

        /// <summary>
        /// Get the system's currency
        /// </summary>
        public string Currency { get; }

        /// <summary>
        /// Get the system's email
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="siteName">The site name</param>
        /// <param name="language">The system's language</param>
        /// <param name="currency">The system's currency</param>
        /// <param name="email">The system's email</param>
        public SetupSettingsCommand(string siteName, string language, string currency, string email)
        {
            SiteName = siteName;
            Language = language;
            Currency = currency;
            Email = email;
        }
    }
}
