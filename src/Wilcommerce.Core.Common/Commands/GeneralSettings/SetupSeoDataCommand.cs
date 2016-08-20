using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Models;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    public class SetupSeoDataCommand : ICommand
    {
        public Guid SettingsId { get; }

        public SeoData Seo { get; }

        public SetupSeoDataCommand(Guid settingsId, SeoData seo)
        {
            SettingsId = settingsId;
            Seo = seo;
        }
    }
}
