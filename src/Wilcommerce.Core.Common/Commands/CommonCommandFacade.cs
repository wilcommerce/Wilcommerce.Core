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
        /// <summary>
        /// Handles the settings setup
        /// </summary>
        public ISetupSettingsCommandHandler SetupSettingsHandler { get; }

        /// <summary>
        /// Handles the change of the system currency
        /// </summary>
        public IChangeCurrencyCommandHandler ChangeCurrencyHandler { get; }

        /// <summary>
        /// Handles the change of the system language
        /// </summary>
        public IChangeLanguageCommandHandler ChangeLanguageHandler { get; }

        /// <summary>
        /// Handles the disabling of site
        /// </summary>
        public IDisableSiteCommandHandler DisableSiteHandler { get; }

        /// <summary>
        /// Handles the enabling of site
        /// </summary>
        public IEnableSiteCommandHandler EnableSiteHandler { get; }

        /// <summary>
        /// Handles the favicon setup
        /// </summary>
        public ISetupFaviconCommandHandler SetupFaviconHandler { get; }

        /// <summary>
        /// Handles the setup of the site logo
        /// </summary>
        public ISetupSiteLogoCommandHandler SetupSiteLogoHandler { get; }

        /// <summary>
        /// Handles the setup of the upload folder
        /// </summary>
        public ISetupUploadFolderCommandHandler SetupUploadFolderHandler { get; }

        /// <summary>
        /// Handles the change of the user email
        /// </summary>
        public IChangeEmailCommandHandler ChangeEmailHandler { get; }

        /// <summary>
        /// Handles the change of the site name
        /// </summary>
        public IChangeSiteNameCommandHandler ChangeSiteNameHandler { get; }

        /// <summary>
        /// Handles the set of the SEO data
        /// </summary>
        public ISetupSeoDataCommandHandler SetSeoDataHandler { get; }

        /// <summary>
        /// Handles the creation of the an administrator user
        /// </summary>
        public ICreateNewAdministratorCommandHandler CreateAdministratorHandler { get; }

        /// <summary>
        /// Handles the enabling of the user
        /// </summary>
        public IEnableUserCommandHandler EnableUserHandler { get; }

        /// <summary>
        /// Handles the disabling of the user
        /// </summary>
        public IDisableUserCommandHandler DisableUserHandler { get; }

        /// <summary>
        /// Handles the disabling of the user name
        /// </summary>
        public IChangeUserNameCommandHandler ChangeUserNameHandler { get; }

        /// <summary>
        /// Handles the change of the user email
        /// </summary>
        public IChangeUserEmailCommandHandler ChangeUserEmailHandler { get; }

        /// <summary>
        /// Handles the change of the user password
        /// </summary>
        public IChangeUserPasswordCommandHandler ChangeUserPasswordHandler { get; }

        /// <summary>
        /// Handles the change of the user role
        /// </summary>
        public IChangeUserRoleCommandHandler ChangeUserRoleHandler { get; }

        /// <summary>
        /// Handles the change of user profile image
        /// </summary>
        public ISetUserProfileCommandHandler SetUserProfileHandler { get; }

        /// <summary>
        /// Construct the command facade, injecting all the command handlers
        /// </summary>
        /// <param name="setupSettingsHandler"></param>
        /// <param name="changeCurrencyHandler"></param>
        /// <param name="changeLanguageHandler"></param>
        /// <param name="disableSiteHandler"></param>
        /// <param name="enableSiteHandler"></param>
        /// <param name="setupFaviconHandler"></param>
        /// <param name="setupSiteLogoHandler"></param>
        /// <param name="setupUploadFolderHandler"></param>
        /// <param name="changeEmailHandler"></param>
        /// <param name="changeSiteNameHandler"></param>
        /// <param name="seoDataHandler"></param>
        /// <param name="createAdministratorHandler"></param>
        /// <param name="enableUserHandler"></param>
        /// <param name="disableUserHandler"></param>
        /// <param name="changeUserNameHandler"></param>
        /// <param name="changeUserEmailHandler"></param>
        /// <param name="changeUserPasswordHandler"></param>
        /// <param name="changeUserRoleHandler"></param>
        /// <param name="setUserProfileHandler"></param>
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
            IChangeUserNameCommandHandler changeUserNameHandler,
            IChangeUserEmailCommandHandler changeUserEmailHandler,
            IChangeUserPasswordCommandHandler changeUserPasswordHandler,
            IChangeUserRoleCommandHandler changeUserRoleHandler,
            ISetUserProfileCommandHandler setUserProfileHandler)
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
            ChangeUserEmailHandler = changeUserEmailHandler;
            ChangeUserPasswordHandler = changeUserPasswordHandler;
            ChangeUserRoleHandler = changeUserRoleHandler;
            SetUserProfileHandler = setUserProfileHandler;
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

        /// <summary>
        /// Create a new administrator user
        /// </summary>
        /// <param name="name">The user's name</param>
        /// <param name="email">The user's email</param>
        /// <param name="password">The user's password</param>
        /// <param name="active">Whether the user is active</param>
        /// <returns></returns>
        public async Task CreateNewAdministrator(string name, string email, string password, bool active)
        {
            try
            {
                var command = new CreateNewAdministratorCommand(
                    name,
                    email,
                    password,
                    active);

                await CreateAdministratorHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Enable the specified user
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <returns></returns>
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

        /// <summary>
        /// Disable the specified user
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <returns></returns>
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

        /// <summary>
        /// Change the user's name
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <param name="name">The new name</param>
        /// <returns></returns>
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

        /// <summary>
        /// Change the user's email
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <param name="email">The new email</param>
        /// <returns></returns>
        public async Task ChangeUserEmail(Guid userId, string email)
        {
            try
            {
                var command = new ChangeUserEmailCommand(userId, email);
                await ChangeUserEmailHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Change the user's password
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <param name="password">The new password</param>
        /// <returns></returns>
        public async Task ChangeUserPassword(Guid userId, string password)
        {
            try
            {
                var command = new ChangeUserPasswordCommand(userId, password);
                await ChangeUserPasswordHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Change the user's role
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <param name="role">The new role</param>
        /// <returns></returns>
        public async Task ChangeUserRole(Guid userId, Domain.Models.User.Roles role)
        {
            try
            {
                var command = new ChangeUserRoleCommand(userId, role);
                await ChangeUserRoleHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Set the user's profile image
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <param name="image">The profile image</param>
        /// <returns></returns>
        public async Task SetProfileImage(Guid userId, Image image)
        {
            try
            {
                var command = new SetUserProfileCommand(userId, image);
                await SetUserProfileHandler.Handle(command);
            }
            catch 
            {
                throw;
            }
        }
    }
}
