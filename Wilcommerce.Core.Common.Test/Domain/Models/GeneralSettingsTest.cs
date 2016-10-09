using Xunit;
using Wilcommerce.Core.Common.Domain.Models;
using System;

namespace Wilcommerce.Core.Common.Test.Domain.Models
{
    public class GeneralSettingsTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void GeneralSettingsFactory_Should_Throw_ArgumentNullException_If_SiteName_IsNullOrEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => GeneralSettings.Create(
                value,
                "IT",
                "EUR",
                "email@email.com"
                ));

            Assert.Equal("siteName", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void GeneralSettingsFactory_Should_Throw_ArgumentNullException_If_Language_IsNullOrEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => GeneralSettings.Create(
                "My Ecommerce",
                value,
                "EUR",
                "email@email.com"
                ));

            Assert.Equal("language", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void GeneralSettingsFactory_Should_Throw_ArgumentNullException_If_Currency_IsNullOrEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                value,
                "email@email.com"
                ));

            Assert.Equal("currency", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void GeneralSettingsFactory_Should_Throw_ArgumentNullException_If_Email_IsNullOrEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                value
                ));

            Assert.Equal("email", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void DisableSite_Should_Throw_ArgumentNullException_If_Message_IsNullOrEmpty(string value)
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            var ex = Assert.Throws<ArgumentNullException>(() => settings.DisableSite(value));

            Assert.Equal("message", ex.ParamName);
        }

        [Fact]
        public void DisableSite_Should_Set_MaintenaceMode_To_True()
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            string message = "This site is under maintenance";
            settings.DisableSite(message);

            Assert.Equal(true, settings.MaintenanceMode);
            Assert.Equal(message, settings.MaintenanceMessage);
        }

        [Fact]
        public void EnableSite_Should_Set_MaintenanceMode_To_False()
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            string message = "This site is under maintenance";
            settings.DisableSite(message);

            settings.EnableSite();

            Assert.Equal(false, settings.MaintenanceMode);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ChangeLanguage_Should_Throw_ArgumentNullException_If_Language_IsEmpty(string value)
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            var ex = Assert.Throws<ArgumentNullException>(() => settings.ChangeLanguage(value));
            Assert.Equal("language", ex.ParamName);
        }

        [Fact]
        public void ChangeLanguage_Should_Change_Current_Language()
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            string newLanguage = "EN";
            settings.ChangeLanguage(newLanguage);

            Assert.Equal(newLanguage, settings.CurrentLanguage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ChangeCurrency_Should_Throw_ArgumentNullException_If_Currency_IsEmpty(string value)
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            var ex = Assert.Throws<ArgumentNullException>(() => settings.ChangeCurrency(value));
            Assert.Equal("currency", ex.ParamName);
        }

        [Fact]
        public void ChangeCurrency_Should_Change_Current_Currency()
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            string newCurrency = "USD";
            settings.ChangeCurrency(newCurrency);

            Assert.Equal(newCurrency, settings.CurrentCurrency);
        }

        [Fact]
        public void SetFavicon_Should_Throw_ArgumentNullException_If_Favicon_IsNull()
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            var ex = Assert.Throws<ArgumentNullException>(() => settings.SetFavicon(null));
            Assert.Equal("favicon", ex.ParamName);
        }
        
        [Fact]
        public void SetSiteLogo_Should_Throw_ArgumentNullException_If_SiteLogo_IsNull()
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            var ex = Assert.Throws<ArgumentNullException>(() => settings.SetSiteLogo(null));
            Assert.Equal("site logo", ex.ParamName);
        }

        [Fact]
        public void SetSeoData_Should_Throw_ArgumentNullException_If_Seo_IsNull()
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            var ex = Assert.Throws<ArgumentNullException>(() => settings.SetSeoData(null));
            Assert.Equal("seo data", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void SetUploadFolder_Should_Throw_ArgumentNullException_If_UploadFolder_IsEmpty(string value)
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            var ex = Assert.Throws<ArgumentNullException>(() => settings.SetUploadFolder(value));
            Assert.Equal("upload folder", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ChangeSiteName_Should_Throw_ArgumentNullException_If_SiteName_IsEmpty(string value)
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            var ex = Assert.Throws<ArgumentNullException>(() => settings.ChangeSiteName(value));
            Assert.Equal("site name", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ChangeEmail_Should_Throw_ArgumentNullException_If_Email_IsEmpty(string value)
        {
            var settings = GeneralSettings.Create(
                "My Ecommerce",
                "IT",
                "EUR",
                "email@email.com"
                );

            var ex = Assert.Throws<ArgumentNullException>(() => settings.ChangeEmail(value));
            Assert.Equal("email", ex.ParamName);
        }
    }
}
