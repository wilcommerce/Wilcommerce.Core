using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.GeneralSettings
{
    /// <summary>
    /// Setup the upload folder
    /// </summary>
    public class SetupUploadFolderCommand : ICommand
    {
        /// <summary>
        /// Get the settings id
        /// </summary>
        public Guid SettingsId { get; }

        /// <summary>
        /// Get the upload folder path
        /// </summary>
        public string UploadFolder { get; }

        /// <summary>
        /// Construct the command
        /// </summary>
        /// <param name="settingsId">The settings id</param>
        /// <param name="uploadFolder">The upload folder path</param>
        public SetupUploadFolderCommand(Guid settingsId, string uploadFolder)
        {
            SettingsId = settingsId;
            UploadFolder = uploadFolder;
        }
    }
}
