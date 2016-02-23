using System.Collections.Generic;
using CurrencyConverter.BL;

namespace CurrencyConverter
{
    public class ExchangeRateCollection : IExchangeRateCollection
    {
        private readonly Dictionary<string, ExchangeRate> exchangeRateCollection = new Dictionary<string, ExchangeRate>();

        public int Count
        {
            get
            {
                return exchangeRateCollection.Count;
            }
        }

        public void AddOrUpdateExchangeRate(ExchangeRate exchangeRate)
        {
            string key = Generatekey(exchangeRate);
            if (!exchangeRateCollection.ContainsKey(key))
            {
                exchangeRateCollection.Add(key, exchangeRate);
            }
            else
            {
                exchangeRateCollection[key] = exchangeRate;
            }
        }

        public IEnumerable<ExchangeRate> GetAllItems()
        {
            return exchangeRateCollection.Values;
        }

        public void RemoveExchangeRate(ExchangeRate exchangeRate)
        {
            string key = Generatekey(exchangeRate);
            if (exchangeRateCollection.ContainsKey(key))
            {
                exchangeRateCollection.Remove(key);
            }
        }

        public ExchangeRate GetByIsoCodes(string isoFrom, string isoTo)
        {
            string key = Generatekey(isoFrom, isoTo);
            if (!exchangeRateCollection.ContainsKey(key))
            {
                return null;
            }
            return exchangeRateCollection[key];
        }

        public void Clear()
        {
            exchangeRateCollection.Clear();
        }

        private string Generatekey(string isoFrom, string isoTo)
        {
            string generatedKey = string.Join("", new string[] { isoFrom, isoTo });

            return generatedKey;
        }

        private string Generatekey(ExchangeRate rate)
        {
            return Generatekey(rate.IsoFrom, rate.IsoTo);
        }
    }
}