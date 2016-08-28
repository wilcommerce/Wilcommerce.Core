using System;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Models;

namespace Wilcommerce.Core.Common.Commands
{
    /// <summary>
    /// Represents the list of available commands for the common package
    /// </summary>
    public interface ICommonCommandFacade
    {
        /// <summary>
        /// Setup the main settings informations
        /// </summary>
        /// <param name="siteName">The site's name</param>
        /// <param name="language">The site's language</param>
        /// <param name="currency">The site's currency</param>
        /// <param name="email">The contact's email</param>
        /// <returns></returns>
        Task SetupSettings(string siteName, string language, string currency, string email);

        /// <summary>
        /// Setup the site's logo
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="siteLogo">The site logo information</param>
        /// <returns></returns>
        Task SetupSiteLogo(Guid settingsId, Image siteLogo);

        /// <summary>
        /// Setup the favicon image
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="favicon">The favicon information</param>
        /// <returns></returns>
        Task SetupFavicon(Guid settingsId, Image favicon);

        /// <summary>
        /// Setup the seo data for the system
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="title">The title metatag</param>
        /// <param name="description">The description metatag</param>
        /// <param name="keywords">The keywords metatag</param>
        /// <param name="ogTitle">The open graph title</param>
        /// <param name="ogType">The open graph type</param>
        /// <param name="ogImage">The open graph image</param>
        /// <param name="ogUrl">The open graph url</param>
        /// <param name="ogAudio">The open graph audio</param>
        /// <param name="ogDescription">The open graph description</param>
        /// <param name="ogDeterminer">The open graph determiner</param>
        /// <param name="ogLocale">The open graph locale</param>
        /// <param name="ogLocaleAlternate">The open graph locale alternate</param>
        /// <param name="ogSiteName">The open graph site's name</param>
        /// <param name="ogVideo">The open graph video</param>
        /// <returns></returns>
        Task SetupSeoData(Guid settingsId, 
            string title, 
            string description, 
            string keywords, 
            string ogTitle, 
            string ogType, 
            string ogImage, 
            string ogUrl, 
            string ogAudio, 
            string ogDescription,
            string ogDeterminer,
            string ogLocale,
            string ogLocaleAlternate,
            string ogSiteName,
            string ogVideo);

        /// <summary>
        /// Setup the upload folder
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="uploadFolder">The upload folder name</param>
        /// <returns></returns>
        Task SetupUploadFolder(Guid settingsId, string uploadFolder);

        /// <summary>
        /// Enable the site
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <returns></returns>
        Task EnableSite(Guid settingsId);

        /// <summary>
        /// Disable the site
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="message">The message to display</param>
        /// <returns></returns>
        Task DisableSite(Guid settingsId, string message);

        /// <summary>
        /// Change the system's language
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="language">The language to set</param>
        /// <returns></returns>
        Task ChangeLanguage(Guid settingsId, string language);

        /// <summary>
        /// Change the sytem's currency code
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="currency">The currency code</param>
        /// <returns></returns>
        Task ChangeCurrency(Guid settingsId, string currency);

        /// <summary>
        /// Change the system's email
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="email">The email to set</param>
        /// <returns></returns>
        Task ChangeEmail(Guid settingsId, string email);

        /// <summary>
        /// Change the site's name
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="siteName">The site's name to set</param>
        /// <returns></returns>
        Task ChangeSiteName(Guid settingsId, string siteName);
    }
}
