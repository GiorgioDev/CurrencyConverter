using CurrencyConverter.BL.Exceptions;

namespace CurrencyConverter.BL
{
    public class ExchangeRate
    {
        public ExchangeRate(string from, string to, double rate)
        {
            if (from == to && rate != 1)
                throw new InvalidRateException();

            if (rate <= 0)
                throw new InvalidRateException(rate);

            this.IsoFrom = from;
            this.IsoTo = to;
            this.Rate = rate;
        }

        public string IsoFrom { get; private set; }

        public string IsoTo { get; private set; }

        public double Rate { get; private set; }
    }
}