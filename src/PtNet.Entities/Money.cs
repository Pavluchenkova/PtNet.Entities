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
            return new Money(0, CurrencyCode.XXX);
        }

        public Money (decimal amount, CurrencyCode currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }
}
