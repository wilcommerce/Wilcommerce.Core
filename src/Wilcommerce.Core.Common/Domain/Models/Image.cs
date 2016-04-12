namespace Wilcommerce.Core.Common.Domain.Models
{
    /// <summary>
    /// Represents an Image
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Get or set the image data
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// Get or set the image
        /// </summary>
        public string MimeType { get; set; }
    }
}
