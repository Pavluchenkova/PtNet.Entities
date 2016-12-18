using System;

namespace PtNet.Entities
{
    public class Money
    {
        public decimal Amount { get; set; }
        public CurrencyCode Currency { get; }

        public Money() : this(0.0m, CurrencyCode.XXX)
        {
        }

        public Money (decimal amount, CurrencyCode currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override string ToString()
        {
            return Amount.ToString() + " " + Currency.ToString();
        }

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Money money = (Money)obj;
                return (this.Amount == money.Amount) && (this.Currency == money.Currency);
            }  
        }

        public override int GetHashCode()
        {
            return (int)this.Amount * (int)this.Currency;
        }

        public static Money operator +(Money x, Money y)
        {
            if (x.Currency != y.Currency)
                throw new InvalidOperationException();
            else
                return new Money(x.Amount + y.Amount, x.Currency);
        }

        public static Money operator -(Money x, Money y)
        {
            if (x.Currency != y.Currency)
                throw new InvalidOperationException();
            else
                return new Money(x.Amount - y.Amount, x.Currency);
        }

        public static Money operator *(Money x, Money y)
        {
            if (x.Currency != y.Currency)
                throw new InvalidOperationException();
            else
                return new Money(x.Amount * y.Amount, x.Currency);
        }

        public static Money operator /(Money x, Money y)
        {
            if (x.Currency != y.Currency)
                throw new InvalidOperationException();
            else
                return new Money(x.Amount / y.Amount, x.Currency);
        }

        public static bool operator ==(Money x, Money y)
        {
            if (x.Currency != y.Currency)
                throw new InvalidOperationException();
            else
                return x.Amount == y.Amount;
        }

        public static bool operator !=(Money x, Money y)
        {
            if (x.Currency != y.Currency)
                throw new InvalidOperationException();
            else
                return x.Amount != y.Amount;
        }

        public static bool operator >(Money x, Money y)
        {
            if (x.Currency != y.Currency)
                throw new InvalidOperationException();
            else
                return x.Amount > y.Amount;
        }

        public static bool operator <(Money x, Money y)
        {
            if (x.Currency != y.Currency)
                throw new InvalidOperationException();
            else
                return x.Amount < y.Amount;
        }

        public static bool operator >=(Money x, Money y)
        {
            if (x.Currency != y.Currency)
                throw new InvalidOperationException();
            else
                return x.Amount >= y.Amount;
        }

        public static bool operator <=(Money x, Money y)
        {
            if (x.Currency != y.Currency)
                throw new InvalidOperationException();
            else
                return x.Amount <= y.Amount;
        }
    }
}