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
        public Guid Id { get; protected set; }

        #region Constructor
        protected GeneralSettings() { }
        #endregion

        #region Properties

        /// <summary>
        /// Get or set the current language
        /// </summary>
        public string CurrentLanguage { get; protected set; }

        /// <summary>
        /// Get or set the current currency code
        /// </summary>
        public string CurrentCurrency { get; protected set; }

        /// <summary>
        /// Get or set the site name
        /// </summary>
        public string SiteName { get; protected set; }

        /// <summary>
        /// Get or set the site logo
        /// </summary>
        public Image SiteLogo { get; protected set; }

        /// <summary>
        /// Get or set the site favicon
        /// </summary>
        public Image Favicon { get; protected set; }

        /// <summary>
        /// Get or set the general email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Get or set whether the site is in maintenance mode
        /// </summary>
        public bool MaintenanceMode { get; protected set; }

        /// <summary>
        /// Get or set the maintenance message
        /// </summary>
        public string MaintenanceMessage { get; protected set; }

        /// <summary>
        /// Get or set the Seo data
        /// </summary>
        public SeoData Seo { get; protected set; }

        /// <summary>
        /// Get or set the root folder for file uploading
        /// </summary>
        public string UploadFolder { get; protected set; }
        #endregion

        #region Behaviors
        /// <summary>
        /// Disable the site and put it in maintenance mode
        /// </summary>
        /// <param name="message">The message to show</param>
        public virtual void DisableSite(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException("message");
            }

            MaintenanceMode = true;
            MaintenanceMessage = message;
        }

        /// <summary>
        /// Enable the site and disable the maintenance mode
        /// </summary>
        public virtual void EnableSite()
        {
            MaintenanceMode = false;
        }

        /// <summary>
        /// Change the current language of the system
        /// </summary>
        /// <param name="language">The language to set</param>
        public virtual void ChangeLanguage(string language)
        {
            if (string.IsNullOrEmpty(language))
            {
                throw new ArgumentNullException("language");
            }

            CurrentLanguage = language;
        }

        /// <summary>
        /// Change the current currency of the system
        /// </summary>
        /// <param name="currency">The currency to set</param>
        public virtual void ChangeCurrency(string currency)
        {
            if (string.IsNullOrEmpty(currency))
            {
                throw new ArgumentNullException("currency");
            }

            CurrentCurrency = currency;
        }

        /// <summary>
        /// Set the system's favicon
        /// </summary>
        /// <param name="favicon">The favicon to set</param>
        public virtual void SetFavicon(Image favicon)
        {
            Favicon = favicon ?? throw new ArgumentNullException("favicon");
        }

        /// <summary>
        /// Set the site's logo
        /// </summary>
        /// <param name="siteLogo">The site's logo to set</param>
        public virtual void SetSiteLogo(Image siteLogo)
        {
            SiteLogo = siteLogo ?? throw new ArgumentNullException("site logo");
        }

        /// <summary>
        /// Set the SEO data fot the system
        /// </summary>
        /// <param name="seo">The SEO data to set</param>
        public virtual void SetSeoData(SeoData seo)
        {
            Seo = seo ?? throw new ArgumentNullException("seo data");
        }

        /// <summary>
        /// Set the upload folder of the system
        /// </summary>
        /// <param name="folder">The upload folder</param>
        public virtual void SetUploadFolder(string folder)
        {
            if (string.IsNullOrEmpty(folder))
            {
                throw new ArgumentNullException("upload folder");
            }

            UploadFolder = folder;
        }

        /// <summary>
        /// Change the site's name
        /// </summary>
        /// <param name="siteName">The site name to set</param>
        public virtual void ChangeSiteName(string siteName)
        {
            if (string.IsNullOrEmpty(siteName))
            {
                throw new ArgumentNullException("site name");
            }

            SiteName = siteName;
        }

        /// <summary>
        /// Change the email of the system
        /// </summary>
        /// <param name="email">The email to set</param>
        public virtual void ChangeEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("email");
            }

            Email = email;
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
