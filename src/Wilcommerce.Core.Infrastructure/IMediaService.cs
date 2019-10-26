using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Wilcommerce.Core.Infrastructure
{
    /// <summary>
    /// Represents the interface to manage the media files
    /// </summary>
    public interface IMediaService
    {
        /// <summary>
        /// Upload a file from a byte array content
        /// </summary>
        /// <param name="path">The path to where upload the file</param>
        /// <param name="fileName">The file name</param>
        /// <param name="fileContent">The file content</param>
        /// <returns></returns>
        Task UploadFromByteArrayAsync(string path, string fileName, byte[] fileContent);

        /// <summary>
        /// Upload a file from a stream content
        /// </summary>
        /// <param name="path">The path where upload the file</param>
        /// <param name="fileName">The file name</param>
        /// <param name="fileContent">The file content</param>
        /// <returns></returns>
        Task UploadFromStreamAsync(string path, string fileName, Stream fileContent);

        /// <summary>
        /// Read all the files in a path
        /// </summary>
        /// <param name="path">The path where read the files</param>
        /// <returns>The list of the file names</returns>
        IEnumerable<string> ReadFilesFromPath(string path);

        /// <summary>
        /// Async method. Read all the files in a path
        /// </summary>
        /// <param name="path">The path where read the files</param>
        /// <returns>The list of the file names</returns>
        Task<IEnumerable<string>> ReadFilesFromPathAsync(string path);
    }
}
