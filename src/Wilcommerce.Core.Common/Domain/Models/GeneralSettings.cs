using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Domain.Models
{
    /// <summary>
    /// Represents the general settings
    /// </summary>
    public class GeneralSettings : IAggregateRoot
    {
        /// <summary>
        /// Get or set the Settings Id
        /// </summary>
        public Guid Id { get; set; }

        #region Constructor
        protected GeneralSettings() { }
        #endregion

        #region Properties

        /// <summary>
        /// Get or set the current language
        /// </summary>
        public string CurrentLanguage { get; set; }

        /// <summary>
        /// Get or set the current currency code
        /// </summary>
        public string CurrentCurrency { get; set; }

        /// <summary>
        /// Get or set the site name
        /// </summary>
        public string SiteName { get; set; }

        /// <summary>
        /// Get or set the site logo
        /// </summary>
        public Image SiteLogo { get; set; }

        /// <summary>
        /// Get or set the site favicon
        /// </summary>
        public Image Favicon { get; set; }

        /// <summary>
        /// Get or set the general email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Get or set whether the site is in maintenance mode
        /// </summary>
        public bool MaintenanceMode { get; set; }

        /// <summary>
        /// Get or set the maintenance message
        /// </summary>
        public string MaintenanceMessage { get; set; }

        /// <summary>
        /// Get or set the Seo data
        /// </summary>
        public SeoData Seo { get; set; }
        #endregion

        #region Behaviors
        /// <summary>
        /// Disable the site and put it in maintenance mode
        /// </summary>
        /// <param name="message">The message to show</param>
        public void DisableSite(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException("message");
            }

            this.MaintenanceMode = true;
            this.MaintenanceMessage = message;
        }

        /// <summary>
        /// Enable the site and disable the maintenance mode
        /// </summary>
        public void EnableSite()
        {
            this.MaintenanceMode = false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Creates a new general setting
        /// </summary>
        /// <param name="siteName">The site name</param>
        /// <param name="language">The current language</param>
        /// <param name="currency">The current currency</param>
        /// <param name="email">The general email address</param>
        /// <returns>The general settings created</returns>
        public static GeneralSettings Create(string siteName, string language, string currency, string email)
        {
            if (string.IsNullOrEmpty(siteName))
            {
                throw new ArgumentNullException("siteName");
            }

            if (string.IsNullOrEmpty(language))
            {
                throw new ArgumentNullException("language");
            }

            if (string.IsNullOrEmpty(currency))
            {
                throw new ArgumentNullException("currency");
            }

            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("email");
            }

            var settings = new GeneralSettings
            {
                SiteName = siteName,
                CurrentLanguage = language,
                CurrentCurrency = currency,
                Email = email
            };

            return settings;
        }
        #endregion
    }
}
