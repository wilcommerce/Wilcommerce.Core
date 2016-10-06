using System;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Commands.GeneralSettings;
using Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers.Interfaces;
using Wilcommerce.Core.Common.Commands.User;
using Wilcommerce.Core.Common.Commands.User.Handlers.Interfaces;
using Wilcommerce.Core.Common.Domain.Models;

namespace Wilcommerce.Core.Common.Commands
{
    /// <summary>
    /// Represents the list of available commands for the common package
    /// </summary>
    public class CommonCommandFacade : ICommonCommandFacade
    {
        public ISetupSettingsCommandHandler SetupSettingsHandler { get; }

        public IChangeCurrencyCommandHandler ChangeCurrencyHandler { get; }

        public IChangeLanguageCommandHandler ChangeLanguageHandler { get; }

        public IDisableSiteCommandHandler DisableSiteHandler { get; }

        public IEnableSiteCommandHandler EnableSiteHandler { get; }

        public ISetupFaviconCommandHandler SetupFaviconHandler { get; }

        public ISetupSiteLogoCommandHandler SetupSiteLogoHandler { get; }

        public ISetupUploadFolderCommandHandler SetupUploadFolderHandler { get; }

        public IChangeEmailCommandHandler ChangeEmailHandler { get; }

        public IChangeSiteNameCommandHandler ChangeSiteNameHandler { get; }

        public ISetupSeoDataCommandHandler SetSeoDataHandler { get; }

        public ICreateNewAdministratorCommandHandler CreateAdministratorHandler { get; }

        public IEnableUserCommandHandler EnableUserHandler { get; }

        public IDisableUserCommandHandler DisableUserHandler { get; }

        public IChangeUserNameCommandHandler ChangeUserNameHandler { get; }

        public CommonCommandFacade(
            ISetupSettingsCommandHandler setupSettingsHandler, 
            IChangeCurrencyCommandHandler changeCurrencyHandler,
            IChangeLanguageCommandHandler changeLanguageHandler,
            IDisableSiteCommandHandler disableSiteHandler,
            IEnableSiteCommandHandler enableSiteHandler,
            ISetupFaviconCommandHandler setupFaviconHandler,
            ISetupSiteLogoCommandHandler setupSiteLogoHandler,
            ISetupUploadFolderCommandHandler setupUploadFolderHandler,
            IChangeEmailCommandHandler changeEmailHandler,
            IChangeSiteNameCommandHandler changeSiteNameHandler,
            ISetupSeoDataCommandHandler seoDataHandler,
            ICreateNewAdministratorCommandHandler createAdministratorHandler,
            IEnableUserCommandHandler enableUserHandler,
            IDisableUserCommandHandler disableUserHandler,
            IChangeUserNameCommandHandler changeUserNameHandler)
        {
            SetupSettingsHandler = setupSettingsHandler;
            ChangeCurrencyHandler = changeCurrencyHandler;
            ChangeLanguageHandler = changeLanguageHandler;
            DisableSiteHandler = disableSiteHandler;
            EnableSiteHandler = enableSiteHandler;
            SetupFaviconHandler = setupFaviconHandler;
            SetupSiteLogoHandler = setupSiteLogoHandler;
            SetupUploadFolderHandler = SetupUploadFolderHandler;
            ChangeEmailHandler = changeEmailHandler;
            ChangeSiteNameHandler = changeSiteNameHandler;
            SetSeoDataHandler = seoDataHandler;
            CreateAdministratorHandler = createAdministratorHandler;
            EnableUserHandler = enableUserHandler;
            DisableUserHandler = disableUserHandler;
            ChangeUserNameHandler = changeUserNameHandler;
        }

        /// <summary>
        /// Change the sytem's currency code
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="currency">The currency code</param>
        /// <returns></returns>
        public async Task ChangeCurrency(Guid settingsId, string currency)
        {
            try
            {
                var command = new ChangeCurrencyCommand(
                    settingsId,
                    currency
                    );

                await ChangeCurrencyHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Change the system's language
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="language">The language to set</param>
        /// <returns></returns>
        public async Task ChangeLanguage(Guid settingsId, string language)
        {
            try
            {
                var command = new ChangeLanguageCommand(
                    settingsId,
                    language
                    );

                await ChangeLanguageHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Disable the site
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="message">The message to display</param>
        /// <returns></returns>
        public async Task DisableSite(Guid settingsId, string message)
        {
            try
            {
                var command = new DisableSiteCommand(
                    settingsId,
                    message
                    );

                await DisableSiteHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Enable the site
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <returns></returns>
        public async Task EnableSite(Guid settingsId)
        {
            try
            {
                var command = new EnableSiteCommand(settingsId);
                await EnableSiteHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Setup the favicon image
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="favicon">The favicon information</param>
        /// <returns></returns>
        public async Task SetupFavicon(Guid settingsId, Image favicon)
        {
            try
            {
                var command = new SetupFaviconCommand(
                    settingsId,
                    favicon
                    );

                await SetupFaviconHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

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
        public async Task SetupSeoData(Guid settingsId, string title, string description, string keywords, string ogTitle, string ogType, string ogImage, string ogUrl, string ogAudio, string ogDescription, string ogDeterminer, string ogLocale, string ogLocaleAlternate, string ogSiteName, string ogVideo)
        {
            try
            {
                var seo = new SeoData
                {
                    Title = title,
                    Description = description,
                    Keywords = keywords,
                    OgTitle = ogTitle,
                    OgType = ogType,
                    OgImage = ogImage,
                    OgUrl = ogUrl,
                    OgAudio = ogAudio,
                    OgDescription = ogDescription,
                    OgDeterminer = ogDeterminer,
                    OgLocale = ogLocale,
                    OgLocaleAlternate = ogLocaleAlternate,
                    OgSiteName = ogSiteName,
                    OgVideo = ogVideo
                };

                var command = new SetupSeoDataCommand(
                    settingsId,
                    seo
                    );

                await SetSeoDataHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Setup the main settings informations
        /// </summary>
        /// <param name="siteName">The site's name</param>
        /// <param name="language">The site's language</param>
        /// <param name="currency">The site's currency</param>
        /// <param name="email">The contact's email</param>
        /// <returns></returns>
        public async Task SetupSettings(string siteName, string language, string currency, string email)
        {
            try
            {
                var command = new SetupSettingsCommand(
                    siteName,
                    language,
                    currency,
                    email
                    );

                await SetupSettingsHandler.Handle(command);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Setup the site's logo
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="siteLogo">The site logo information</param>
        /// <returns></returns>
        public async Task SetupSiteLogo(Guid settingsId, Image siteLogo)
        {
            try
            {
                var command = new SetupSiteLogoCommand(
                    settingsId,
                    siteLogo
                    );

                await SetupSiteLogoHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Setup the upload folder
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="uploadFolder">The upload folder name</param>
        /// <returns></returns>
        public async Task SetupUploadFolder(Guid settingsId, string uploadFolder)
        {
            try
            {
                var command = new SetupUploadFolderCommand(
                    settingsId,
                    uploadFolder
                    );

                await SetupUploadFolderHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Change the system's email
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="email">The email to set</param>
        /// <returns></returns>
        public async Task ChangeEmail(Guid settingsId, string email)
        {
            try
            {
                var command = new ChangeEmailCommand(
                    settingsId,
                    email
                    );

                await ChangeEmailHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Change the site's name
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="siteName">The site's name to set</param>
        /// <returns></returns>
        public async Task ChangeSiteName(Guid settingsId, string siteName)
        {
            try
            {
                var command = new ChangeSiteNameCommand(
                    settingsId,
                    siteName
                    );

                await ChangeSiteNameHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        public async Task CreateNewAdministrator(string name, string email, string password)
        {
            try
            {
                var command = new CreateNewAdministratorCommand(
                    name,
                    email,
                    password
                    );

                await CreateAdministratorHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        public async Task EnableUser(Guid userId)
        {
            try
            {
                var command = new EnableUserCommand(userId);
                await EnableUserHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        public async Task DisableUser(Guid userId)
        {
            try
            {
                var command = new DisableUserCommand(userId);
                await DisableUserHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        public async Task ChangeUserName(Guid userId, string name)
        {
            try
            {
                var command = new ChangeUserNameCommand(userId, name);
                await ChangeUserNameHandler.Handle(command);
            }
            catch
            {
                throw;
            }
        }

        public Task ChangeUserEmail(Guid userId, string email)
        {
            throw new NotImplementedException();
        }

        public Task ChangeUserPassword(Guid userId, string password)
        {
            throw new NotImplementedException();
        }

        public Task ChangeUserRole(Guid userId, Domain.Models.User.Roles role)
        {
            throw new NotImplementedException();
        }

        public Task SetProfileImage(Guid userId, Image image)
        {
            throw new NotImplementedException();
        }
    }
}
