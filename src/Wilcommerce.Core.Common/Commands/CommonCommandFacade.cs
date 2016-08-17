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

        public CommonCommandFacade(
            ISetupSettingsCommandHandler setupSettingsHandler, 
            IChangeCurrencyCommandHandler changeCurrencyHandler,
            IChangeLanguageCommandHandler changeLanguageHandler,
            IDisableSiteCommandHandler disableSiteHandler)
        {
            SetupSettingsHandler = setupSettingsHandler;
            ChangeCurrencyHandler = changeCurrencyHandler;
            ChangeLanguageHandler = changeLanguageHandler;
            DisableSiteHandler = disableSiteHandler;
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

        public Task EnableSite(Guid settingsId)
        {
            throw new NotImplementedException();
        }

        public Task SetupFavicon(Guid settingsId, Image favicon)
        {
            throw new NotImplementedException();
        }

        public Task SetupSeoData(Guid settingsId, string title, string description, string keywords, string ogTitle, string ogType, string ogImage, string ogUrl, string ogAudio, string ogDescription, string ogDeterminer, string ogLocale, string ogLocaleAlternate, string ogSiteName, string ogVideo)
        {
            throw new NotImplementedException();
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

        public Task SetupSiteLogo(Guid settingsId, Image siteLogo)
        {
            throw new NotImplementedException();
        }

        public Task SetupUploadFolder(Guid settingsId, string uploadFolder)
        {
            throw new NotImplementedException();
        }
    }
}
