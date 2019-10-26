using Wilcommerce.Core.Common.Models;
using Xunit;

namespace Wilcommerce.Core.Common.Test.Models
{
    public class ImageTests
    {
        #region Operators Tests
        [Fact]
        public void EqualOperator_Should_Return_True_If_Both_Images_Are_Null()
        {
            Image image1 = null;
            Image image2 = null;

            Assert.True(image1 == image2);
        }

        [Fact]
        public void EqualOperator_Should_Return_False_If_the_First_Image_Is_Not_Null_And_The_Second_Image_Is_Null()
        {
            Image image1 = new Image
            {
                MimeType = "application/jpg",
                Data = new byte[0]
            };

            Image image2 = null;

            Assert.False(image1 == image2);
        }

        [Fact]
        public void EqualOperator_Should_Return_False_If_the_First_Image_Is_Null_And_The_Second_Image_Is_Not_Null()
        {
            Image image1 = null;
            Image image2 = new Image
            {
                MimeType = "application/jpg",
                Data = new byte[0]
            };

            Assert.False(image1 == image2);
        }

        [Fact]
        public void EqualOperator_Should_Return_True_If_Both_Images_Are_Not_Null_And_Are_Equals()
        {
            Image image1 = new Image
            {
                MimeType = "application/jpg",
                Data = new byte[] { 1 }
            };
            Image image2 = new Image
            {
                MimeType = "application/jpg",
                Data = new byte[] { 1 }
            };

            Assert.True(image1 == image2);
        }

        [Fact]
        public void EqualOperator_Should_Return_False_If_Both_Images_Are_Not_Null_But_Are_Different()
        {
            Image image1 = new Image
            {
                MimeType = "application/png",
                Data = new byte[0]
            };
            Image image2 = new Image
            {
                MimeType = "application/jpg",
                Data = new byte[0]
            };

            Assert.False(image1 == image2);
        }
        #endregion
    }
}
