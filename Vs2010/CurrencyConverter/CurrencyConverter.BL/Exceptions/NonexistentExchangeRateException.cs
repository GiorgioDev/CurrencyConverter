using System;

namespace CurrencyConverter.BL.Exceptions
{
    public class NonExistentExchangeRateException : Exception
    {
        public NonExistentExchangeRateException(string from, string to) : base(string.Format("Non-Existent exchange rate convertion from '{0}' to '{1}'", from, to))
        {
        }
    }
}