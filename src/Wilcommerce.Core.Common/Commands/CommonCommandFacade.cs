using System;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Commands.GeneralSettings;
using Wilcommerce.Core.Common.Commands.GeneralSettings.Handlers.Interfaces;
using Wilcommerce.Core.Common.Domain.Models;

namespace Wilcommerce.Core.Common.Commands
{
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
            ISetupSeoDataCommandHandler seoDataHandler)
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
        }

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
    }
}
