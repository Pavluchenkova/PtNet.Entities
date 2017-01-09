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
            return $"{Amount} {Currency}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var money = obj as Money;
            if (money != null)
            {
                return (this.Amount == money.Amount) && (this.Currency == money.Currency);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return (int)this.Amount * (int)this.Currency;
        }

        public static Money operator +(Money x, Money y)
        {
           CurrencyCheck(x, y);
           return new Money(x.Amount + y.Amount, x.Currency);
        }

        public static Money operator -(Money x, Money y)
        {
          CurrencyCheck(x,y);        
          return new Money(x.Amount - y.Amount, x.Currency);
        }

        public static Money operator *(Money x, Money y)
        {
           CurrencyCheck(x, y);
           return new Money(x.Amount * y.Amount, x.Currency);
        }

        public static Money operator /(Money x, Money y)
        {
            CurrencyCheck(x, y);
            return new Money(x.Amount / y.Amount, x.Currency);
        }

        public static bool operator ==(Money x, Money y)
        {
            if ((object)x == null || (object)y == null)
            {
                return false;
            }
            CurrencyCheck(x, y);
            return x.Amount == y.Amount;          
        }

        public static bool operator !=(Money x, Money y)
        {
            if ((object)x == null || (object)y == null)
            {
                return false;
            }
            CurrencyCheck(x, y);
            return x.Amount != y.Amount;
        }

        public static bool operator >(Money x, Money y)
        {
            if ((object)x == null || (object)y == null)
            {
                return false;
            }
            CurrencyCheck(x, y);
            return x.Amount > y.Amount;
        }

        public static bool operator <(Money x, Money y)
        {
            if ((object)x == null || (object)y == null)
            {
                return false;
            }
            CurrencyCheck(x, y);
            return x.Amount < y.Amount;       
        }

        public static bool operator >=(Money x, Money y)
        {
            if ((object)x == null || (object)y == null)
            {
                return false;
            }
            CurrencyCheck(x, y);
            return x.Amount >= y.Amount;
        }

        public static bool operator <=(Money x, Money y)
        {
            if ((object)x == null || (object)y == null)
            {
                return false;
            }
            CurrencyCheck(x, y);
            return x.Amount <= y.Amount;
        }

        private static void CurrencyCheck(Money x, Money y)
        {
            if (x.Currency != y.Currency)
            {
                throw new InvalidOperationException();
            }
        }
    }
}