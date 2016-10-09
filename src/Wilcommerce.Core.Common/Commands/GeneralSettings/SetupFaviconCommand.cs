using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Models;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    public class SetupFaviconCommand : ICommand
    {
        public Guid SettingsId { get; }

        public Image Favicon { get; }

        public SetupFaviconCommand(Guid settingsId, Image favicon)
        {
            SettingsId = settingsId;
            Favicon = favicon;
        }
    }
}
