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

        #region Public Methods
        public override int GetHashCode()
        {
            return Data.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var img = obj as Image;
            if (img == null)
            {
                return false;
            }

            return (MimeType == img.MimeType && Data == img.Data);
        }
        #endregion

        #region Operators
        public static bool operator==(Image img1, Image img2)
        {
            if (ReferenceEquals(img1, null))
            {
                return ReferenceEquals(null, img2);
            }

            return img1.Equals(img2);
        }

        public static bool operator!=(Image img1, Image img2)
        {
            return !(img1 == img2);
        }
        #endregion
    }
}
