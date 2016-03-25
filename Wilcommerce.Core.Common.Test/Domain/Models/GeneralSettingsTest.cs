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
    }
}
