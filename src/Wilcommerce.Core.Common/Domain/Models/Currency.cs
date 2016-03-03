using System;

namespace Wilcommerce.Core.Common.Domain.Models
{
    /// <summary>
    /// Represents a Currency
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// The currency code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The currency amount
        /// </summary>
        public double Amount { get; set; }

        #region Operators
        /// <summary>
        /// Sum two currencies
        /// </summary>
        /// <param name="firstCurrency">The first currency</param>
        /// <param name="secondCurrency">The second currency</param>
        /// <returns>The currency sum</returns>
        public static Currency operator+(Currency firstCurrency, Currency secondCurrency)
        {
            if(firstCurrency == null)
            {
                throw new ArgumentNullException("firstCurrency");
            }

            if(firstCurrency.Amount < 0)
            {
                throw new ArgumentException("The currency must be greater than or equal to zero");
            }

            if(secondCurrency == null)
            {
                throw new ArgumentNullException("secondCurrency");
            }

            if (secondCurrency.Amount < 0)
            {
                throw new ArgumentException("The currency must be greater than or equal to zero");
            }

            if (firstCurrency.Code != secondCurrency.Code)
            {
                throw new ArgumentException("The currency must be of the same type");
            }

            double result = firstCurrency.Amount + secondCurrency.Amount;
            if (result < 0)
            {
                throw new InvalidOperationException("The result must be greater than or equals to zero");
            }

            return new Currency
            {
                Code = firstCurrency.Code,
                Amount = result
            };
        }

        /// <summary>
        /// Subtract two currencies
        /// </summary>
        /// <param name="firstCurrency">The first currency</param>
        /// <param name="secondCurrency">The second currency</param>
        /// <returns>The currency difference</returns>
        public static Currency operator-(Currency firstCurrency, Currency secondCurrency)
        {
            if (firstCurrency == null)
            {
                throw new ArgumentNullException("firstCurrency");
            }

            if (firstCurrency.Amount < 0)
            {
                throw new ArgumentException("The currency must be greater than or equal to zero");
            }

            if (secondCurrency == null)
            {
                throw new ArgumentNullException("secondCurrency");
            }

            if (secondCurrency.Amount < 0)
            {
                throw new ArgumentException("The currency must be greater than or equal to zero");
            }

            if (firstCurrency.Code != secondCurrency.Code)
            {
                throw new ArgumentException("The currency must be of the same type");
            }

            double result = firstCurrency.Amount - secondCurrency.Amount;
            if(result < 0)
            {
                throw new InvalidOperationException("The result must be greater than or equals to zero");
            }

            return new Currency
            {
                Code = firstCurrency.Code,
                Amount = result
            };
        }

        /// <summary>
        /// Multiply two currencies
        /// </summary>
        /// <param name="firstCurrency">The first currency</param>
        /// <param name="secondCurrency">The second currency</param>
        /// <returns>The currency multiplication</returns>
        public static Currency operator*(Currency firstCurrency, Currency secondCurrency)
        {
            if (firstCurrency == null)
            {
                throw new ArgumentNullException("firstCurrency");
            }

            if (firstCurrency.Amount < 0)
            {
                throw new ArgumentException("The currency must be greater than or equal to zero");
            }

            if (secondCurrency == null)
            {
                throw new ArgumentNullException("secondCurrency");
            }

            if (secondCurrency.Amount < 0)
            {
                throw new ArgumentException("The currency must be greater than or equal to zero");
            }

            double result = firstCurrency.Amount * secondCurrency.Amount;
            if(result < 0)
            {
                throw new InvalidOperationException("The result must be greater than or equals to zero");
            }

            return new Currency
            {
                Code = firstCurrency.Code,
                Amount = result
            };
        }

        /// <summary>
        /// Divide two currencies
        /// </summary>
        /// <param name="firstCurrency">The first currency</param>
        /// <param name="secondCurrency">The second currency</param>
        /// <returns>The currency division</returns>
        public static Currency operator/(Currency firstCurrency, Currency secondCurrency)
        {
            if (firstCurrency == null)
            {
                throw new ArgumentNullException("firstCurrency");
            }

            if (firstCurrency.Amount < 0)
            {
                throw new ArgumentException("The currency must be greater than or equal to zero");
            }

            if (secondCurrency == null)
            {
                throw new ArgumentNullException("secondCurrency");
            }

            if (secondCurrency.Amount <= 0)
            {
                throw new ArgumentException("The currency must be greater than to zero");
            }

            double result = firstCurrency.Amount / secondCurrency.Amount;
            if (result < 0)
            {
                throw new InvalidOperationException("The result must be greater than or equals to zero");
            }

            return new Currency
            {
                Code = firstCurrency.Code,
                Amount = result
            };
        }
        #endregion
    }
}
