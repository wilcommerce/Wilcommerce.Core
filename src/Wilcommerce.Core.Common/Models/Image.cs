using System.Linq;

namespace Wilcommerce.Core.Common.Models
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
        /// <summary>
        /// Returns the hash code for the object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => Data.GetHashCode();

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare</param>
        /// <returns>true if the specified object is equal to the current, false otherwise</returns>
        public override bool Equals(object obj)
        {
            if (obj is not Image img)
            {
                return false;
            }

            return (MimeType == img.MimeType && Data.SequenceEqual(img.Data));
        }
        #endregion

        #region Operators
        /// <summary>
        /// Compare the two images and return true if they're equal
        /// </summary>
        /// <param name="img1">The first image</param>
        /// <param name="img2">The second image</param>
        /// <returns>true if the images are equal, false otherwise</returns>
        public static bool operator==(Image img1, Image img2)
        {
            if (ReferenceEquals(img1, null))
            {
                return ReferenceEquals(null, img2);
            }

            return img1.Equals(img2);
        }

        /// <summary>
        /// Compare the two images and return true if they're not equal
        /// </summary>
        /// <param name="img1">The first image</param>
        /// <param name="img2">The second image</param>
        /// <returns>true if the images are not equal, false otherwise</returns>
        public static bool operator !=(Image img1, Image img2) => !(img1 == img2);
        #endregion
    }
}
