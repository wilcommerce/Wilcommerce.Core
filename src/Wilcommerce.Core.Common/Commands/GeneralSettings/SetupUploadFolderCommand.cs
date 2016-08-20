using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    public class SetupUploadFolderCommand : ICommand
    {
        public Guid SettingsId { get; }

        public string UploadFolder { get; }

        public SetupUploadFolderCommand(Guid settingsId, string uploadFolder)
        {
            SettingsId = settingsId;
            UploadFolder = uploadFolder;
        }
    }
}
