using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtNet.Entities
{
    public class Money
    {
        public decimal Amount { get; set; }
        public CurrencyCode Currency { get; set; }

        public Money()
        {
            new Money(0, CurrencyCode.XXX);
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

        public override bool Equals (object obj)
        {
            var item = obj as Money;

            if (item == null)
            {
                return false;
            }

            return (this.Amount == item.Amount) && (this.Currency == item.Currency);
        }
        
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public static Money operator +(Money x, Money y)
        {
            if (x.Currency != y.Currency)
            {
                throw new InvalidOperationException();
            }

            return new Money(x.Amount+y.Amount, x.Currency);
        }

        public static Money operator -(Money x, Money y)
        {
            if (x.Currency != y.Currency)
            {
                throw new InvalidOperationException();
            }
            
            return new Money(x.Amount-y.Amount, x.Currency);
        }

        public static Money operator *(Money x, Money y)
        {
            if (x.Currency != y.Currency)
            {
                throw new InvalidOperationException();
            }
            
            return new Money(x.Amount*y.Amount, x.Currency);
        }

        public static Money operator /(Money x, Money y)
        {
            if (x.Currency != y.Currency)
            {
                throw new InvalidOperationException();
            }
            
            return new Money(x.Amount/y.Amount, x.Currency);
        }

        public static bool operator ==(Money x, Money y)
        {
            return (x.Amount == y.Amount) && (x.Currency == y.Currency);
        }

        public static bool operator !=(Money x, Money y)
        {
            return (x.Amount != y.Amount) && (x.Currency != y.Currency);
        }
    }
}