using System;

namespace CurrencyConverter.BL.Exceptions
{
    public class InvalidRateException : Exception
    {
        public InvalidRateException() : base(string.Format("Rate should be a equals 1 in case of identical Iso Codes"))
        {
        }

        public InvalidRateException(double rate) : base(string.Format("Rate should be a positive number. Given rate: '{0}'", rate))
        {
        }
    }
}