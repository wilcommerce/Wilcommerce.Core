namespace Wilcommerce.Core.Common.Domain.Models
{
    /// <summary>
    /// Represents the Seo information
    /// </summary>
    public class SeoData
    {
        #region General Information

        /// <summary>
        /// Get or set the title metatag
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Get or set the description metatag
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Get or set the keywords metatag
        /// </summary>
        public string Keywords { get; set; }
        #endregion

        #region Open Graph

        /// <summary>
        /// Get or set the Open Graph title metatag
        /// </summary>
        public string OgTitle { get; set; }

        /// <summary>
        /// Get or set the Open Graph type metatag
        /// </summary>
        public string OgType { get; set; }

        /// <summary>
        /// Get or set the Open Graph image metatag
        /// </summary>
        public string OgImage { get; set; }

        /// <summary>
        /// Get or set the Open Graph url metatag
        /// </summary>
        public string OgUrl { get; set; }

        /// <summary>
        /// Get or set the Open Graph audio metatag
        /// </summary>
        public string OgAudio { get; set; }

        /// <summary>
        /// Get or set the Open Graph description metatag
        /// </summary>
        public string OgDescription { get; set; }

        /// <summary>
        /// Get or set the Open Graph determiner metatag
        /// </summary>
        public string OgDeterminer { get; set; }

        /// <summary>
        /// Get or set the Open Graph locale metatag
        /// </summary>
        public string OgLocale { get; set; }

        /// <summary>
        /// Get or set the Open Graph locale alternate metatag
        /// </summary>
        public string OgLocaleAlternate { get; set; }

        /// <summary>
        /// Get or set the Open Graph site name metatag
        /// </summary>
        public string OgSiteName { get; set; }

        /// <summary>
        /// Get or set the Open Graph video metatag
        /// </summary>
        public string OgVideo { get; set; }
        #endregion
    }
}
