using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PtNet.Entities.Tests
{
    [TestClass]
    public class MoneyGeneralTests
    {
        [TestMethod]
        public void Money_default_constructor_should_create_proper_default_Money()
        {
            var expected = new Money(0.0m, CurrencyCode.XXX);

            var actual = new Money();

            Assert.AreEqual(expected.Amount, actual.Amount);
            Assert.AreEqual(expected.Currency, actual.Currency);
        }
        
        [TestMethod]
        public void ToString_should_return_properly_formatted_string()
        {
            var money = new Money(10, CurrencyCode.XXX);

            var expected = "10 XXX";

            var actual = money.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
