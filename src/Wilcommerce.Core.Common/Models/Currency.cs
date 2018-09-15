using System;

namespace Wilcommerce.Core.Common.Models
{
    /// <summary>
    /// Represents a Currency
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Get or set the currency code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Get or set the currency amount
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

            if (firstCurrency.Code != secondCurrency.Code)
            {
                throw new ArgumentException("The currency must be of the same type");
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

            if (firstCurrency.Code != secondCurrency.Code)
            {
                throw new ArgumentException("The currency must be of the same type");
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

        /// <summary>
        /// Compare the two currencies and return true if they're equal
        /// </summary>
        /// <param name="firstCurrency">The first currency</param>
        /// <param name="secondCurrency">The second currency</param>
        /// <returns>true if the're equal, false otherwise</returns>
        public static bool operator==(Currency firstCurrency, Currency secondCurrency)
        {
            if (ReferenceEquals(firstCurrency, null))
            {
                return ReferenceEquals(null, secondCurrency);
            }

            return firstCurrency.Equals(secondCurrency);
        }

        /// <summary>
        /// Compare the two currencies and return true if they're not equal
        /// </summary>
        /// <param name="firstCurrency">The first currency</param>
        /// <param name="secondCurrency">The second currency</param>
        /// <returns>true if the currencies are not equal, false otherwise</returns>
        public static bool operator!=(Currency firstCurrency, Currency secondCurrency)
        {
            return !(firstCurrency == secondCurrency);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Calculate the percentage of the current currency
        /// </summary>
        /// <param name="percentage">The percentage value</param>
        /// <returns>The currency calculated</returns>
        public virtual Currency Percentage(double percentage)
        {
            var amount = Amount * (percentage / 100.00);

            return new Currency
            {
                Code = this.Code,
                Amount = amount
            };
        }

        /// <summary>
        /// Returns the hash code for the object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        /// <summary>
        /// Converts the currency object to a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Code} {Amount.ToString()}";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare</param>
        /// <returns>true if the specified object is equal to the current, false otherwise</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var currency = obj as Currency;
            if (currency == null)
            {
                return false;
            }

            return (Code == currency.Code && Amount == currency.Amount);
        }
        #endregion
    }
}
