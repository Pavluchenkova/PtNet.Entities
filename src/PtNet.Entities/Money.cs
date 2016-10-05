using System;

namespace PtNet.Entities
{
    public class Money
    {
        public decimal Amount { get; set; }
        public CurrencyCode Currency { get; }

        public Money()
        {
            new Money(0.0m, CurrencyCode.XXX);
        }

        public Money (decimal amount, CurrencyCode currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override string ToString()
        {
            // TODO: Implement ToString() method
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            // TODO: Implement Equals() method
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            // TODO: Implement GetHashCode() method
            return base.GetHashCode();
        }
    }
}