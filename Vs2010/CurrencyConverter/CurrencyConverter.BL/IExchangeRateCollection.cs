namespace CurrencyConverter.BL
{
    public interface IExchangeRateCollection
    {
        int Count { get; }

        ExchangeRate GetByIsoCodes(string isoFrom, string isoTo);
    }
}