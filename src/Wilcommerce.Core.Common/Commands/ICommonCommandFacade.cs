using System;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Models;

namespace Wilcommerce.Core.Common.Commands
{
    public interface ICommonCommandFacade
    {
        Task SetupSettings(string siteName, string language, string currency, string email);

        Task SetupSiteLogo(Guid settingsId, Image siteLogo);

        Task SetupFavicon(Guid settingsId, Image favicon);

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

        Task SetupUploadFolder(Guid settingsId, string uploadFolder);

        Task EnableSite(Guid settingsId);

        Task DisableSite(Guid settingsId, string message);

        Task ChangeLanguage(Guid settingsId, string language);

        Task ChangeCurrency(Guid settingsId, string currency);
    }
}
