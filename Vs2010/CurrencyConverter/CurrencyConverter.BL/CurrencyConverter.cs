using System;
using CurrencyConverter.BL.Exceptions;

namespace CurrencyConverter.BL
{
    public class CurrencyConverter
    {
        private IExchangeRateCollection exchangeRates;

        public void SetExchangeRateCollection(IExchangeRateCollection collection)
        {
            if (collection == null || collection.Count == 0)
            {
                throw new InvalidOperationException("Given collection is not Initialized");
            }

            exchangeRates = collection;
        }

        public double Convert(string isoFrom, string isoTo, double amount)
        {
            ExchangeRate exchangeRate = exchangeRates.GetByIsoCodes(isoFrom, isoTo);

            if (exchangeRate == null)
                throw new NonExistentExchangeRateException(isoFrom, isoTo);

            return amount * exchangeRate.Rate;
        }
    }
}