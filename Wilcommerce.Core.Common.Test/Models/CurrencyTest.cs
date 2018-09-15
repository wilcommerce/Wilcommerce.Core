using Xunit;
using Wilcommerce.Core.Common.Models;
using System;

namespace Wilcommerce.Core.Common.Test.Models
{
    public class CurrencyTest
    {
        #region Sum Test
        [Fact]
        public void Sum_Should_Throw_ArgumentNullException_If_AnArgument_IsNull()
        {
            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            Currency c1 = null;

            var ex = Assert.Throws<ArgumentNullException>(() => (c1 + c2));
            var ex1 = Assert.Throws<ArgumentNullException>(() => (c2 + c1));

            Assert.Equal("firstCurrency", ex.ParamName);
            Assert.Equal("secondCurrency", ex1.ParamName);
        }

        [Fact]
        public void Sum_Should_Throw_ArgumentException_If_AnArgument_IsLessThanZero()
        {
            var c1 = new Currency
            {
                Code = "EUR",
                Amount = -10
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var ex = Assert.Throws<ArgumentException>(() => (c1 + c2));
            var ex1 = Assert.Throws<ArgumentException>(() => (c2 + c1));

            Assert.Equal("firstCurrency", ex.ParamName);
            Assert.Equal("secondCurrency", ex1.ParamName);
        }

        [Fact]
        public void Sum_Should_Throw_ArgumentException_If_Code_IsDifferent()
        {
            var c1 = new Currency
            {
                Code = "USD",
                Amount = 10
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var ex = Assert.Throws<ArgumentException>(() => (c1 + c2));
            Assert.Equal("The currency must be of the same type", ex.Message);
        }

        [Fact]
        public void Sum_Amount_Should_Be_Sum_Of_Currencies()
        {
            var c1 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 20
            };

            var sum = c1 + c2;

            Assert.Equal(c1.Code, sum.Code);
            Assert.Equal((c1.Amount + c2.Amount), sum.Amount);
        }
        #endregion

        #region Difference Test
        [Fact]
        public void Difference_Should_Throw_ArgumentNullException_If_AnArgument_IsNull()
        {
            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            Currency c1 = null;

            var ex = Assert.Throws<ArgumentNullException>(() => (c1 - c2));
            var ex1 = Assert.Throws<ArgumentNullException>(() => (c2 - c1));

            Assert.Equal("firstCurrency", ex.ParamName);
            Assert.Equal("secondCurrency", ex1.ParamName);
        }

        [Fact]
        public void Difference_Should_Throw_ArgumentException_If_AnArgument_IsLessThanZero()
        {
            var c1 = new Currency
            {
                Code = "EUR",
                Amount = -10
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var ex = Assert.Throws<ArgumentException>(() => (c1 - c2));
            var ex1 = Assert.Throws<ArgumentException>(() => (c2 - c1));

            Assert.Equal("firstCurrency", ex.ParamName);
            Assert.Equal("secondCurrency", ex1.ParamName);
        }

        [Fact]
        public void Difference_Should_Throw_ArgumentException_If_Code_IsDifferent()
        {
            var c1 = new Currency
            {
                Code = "USD",
                Amount = 10
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var ex = Assert.Throws<ArgumentException>(() => (c1 - c2));
            Assert.Equal("The currency must be of the same type", ex.Message);
        }

        [Fact]
        public void Difference_Should_Throw_InvalidOperationException_If_Result_IsLessThanZero()
        {
            var c1 = new Currency
            {
                Code = "EUR",
                Amount = 20
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 30
            };

            var ex = Assert.Throws<InvalidOperationException>(() => (c1 - c2));
            Assert.Equal("The result must be greater than or equals to zero", ex.Message);
        }

        [Fact]
        public void Difference_Amount_Should_Be_Difference_Of_Currencies()
        {
            var c1 = new Currency
            {
                Code = "EUR",
                Amount = 20
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var difference = c1 - c2;

            Assert.Equal(c1.Code, difference.Code);
            Assert.Equal((c1.Amount - c2.Amount), difference.Amount);
        }
        #endregion

        #region Product Test
        [Fact]
        public void Product_Should_Throw_ArgumentNullException_If_AnArgument_IsNull()
        {
            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            Currency c1 = null;

            var ex = Assert.Throws<ArgumentNullException>(() => (c1 * c2));
            var ex1 = Assert.Throws<ArgumentNullException>(() => (c2 * c1));

            Assert.Equal("firstCurrency", ex.ParamName);
            Assert.Equal("secondCurrency", ex1.ParamName);
        }

        [Fact]
        public void Product_Should_Throw_ArgumentNullException_If_AnArgument_IsLessThanZero()
        {
            var c1 = new Currency
            {
                Code = "EUR",
                Amount = -10
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var ex = Assert.Throws<ArgumentException>(() => (c1 * c2));
            var ex1 = Assert.Throws<ArgumentException>(() => (c2 * c1));

            Assert.Equal("firstCurrency", ex.ParamName);
            Assert.Equal("secondCurrency", ex1.ParamName);
        }

        [Fact]
        public void Product_Should_Throw_ArgumentException_If_Code_IsDifferent()
        {
            var c1 = new Currency
            {
                Code = "USD",
                Amount = 10
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var ex = Assert.Throws<ArgumentException>(() => (c1 * c2));
            Assert.Equal("The currency must be of the same type", ex.Message);
        }

        [Fact]
        public void Product_Amount_Should_Be_Product_Of_Currencies()
        {
            var c1 = new Currency
            {
                Code = "EUR",
                Amount = 20
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var product = c1 * c2;

            Assert.Equal(c1.Code, product.Code);
            Assert.Equal((c1.Amount * c2.Amount), product.Amount);
        }
        #endregion

        #region Division Test
        [Fact]
        public void Division_Should_Throw_ArgumentNullException_If_AnArgument_IsNull()
        {
            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            Currency c1 = null;

            var ex = Assert.Throws<ArgumentNullException>(() => (c1 / c2));
            var ex1 = Assert.Throws<ArgumentNullException>(() => (c2 / c1));

            Assert.Equal("firstCurrency", ex.ParamName);
            Assert.Equal("secondCurrency", ex1.ParamName);
        }

        [Fact]
        public void Division_Should_Throw_ArgumentException_If_Numerator_IsLessThanZero()
        {
            var c1 = new Currency
            {
                Code = "EUR",
                Amount = -10
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var ex = Assert.Throws<ArgumentException>(() => (c1 / c2));

            Assert.Equal("firstCurrency", ex.ParamName);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        public void Division_Should_Throw_ArgumentException_If_Denominator_IsLessThan_OrEqualTo_Zero(double value)
        {
            var c1 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = value
            };

            var ex = Assert.Throws<ArgumentException>(() => (c1 / c2));

            Assert.Equal("secondCurrency", ex.ParamName);
        }

        [Fact]
        public void Division_Should_Throw_ArgumentException_If_Code_IsDifferent()
        {
            var c1 = new Currency
            {
                Code = "USD",
                Amount = 10
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var ex = Assert.Throws<ArgumentException>(() => (c1 / c2));
            Assert.Equal("The currency must be of the same type", ex.Message);
        }

        [Fact]
        public void Division_Amount_Should_Be_Division_Of_Currencies()
        {
            var c1 = new Currency
            {
                Code = "EUR",
                Amount = 20
            };

            var c2 = new Currency
            {
                Code = "EUR",
                Amount = 10
            };

            var division = c1 / c2;

            Assert.Equal(c1.Code, division.Code);
            Assert.Equal((c1.Amount / c2.Amount), division.Amount);
        }
        #endregion

        #region Percentage Test
        [Fact]
        public void Percentage_Should_Calculate_Amount_Percentage()
        {
            var currency = new Currency
            {
                Code = "EUR",
                Amount = 100
            };

            double value = 10;
            var percentage = currency.Percentage(value);

            Assert.Equal(currency.Code, percentage.Code);
            Assert.Equal(currency.Amount * (value / 100.00), percentage.Amount);
        }
        #endregion
    }
}
