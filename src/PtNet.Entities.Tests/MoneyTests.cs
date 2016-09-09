using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PtNet.Entities.Tests
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void Money_plus_operator_should_add_two_Money_objects_correctly()
        {
            var x = new Money(25, CurrencyCode.XXX);
            var y = new Money(15, CurrencyCode.XXX);

            var expected = new Money(40, CurrencyCode.XXX);

            var actual = x + y;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Money_minus_operator_should_substract_two_Money_objects_correctly()
        {
            var x = new Money(25, CurrencyCode.XXX);
            var y = new Money(15, CurrencyCode.XXX);

            var expected = new Money(10, CurrencyCode.XXX);

            var actual = x - y;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Money_multiply_operator_should_multiply_two_Money_objects_correctly()
        {
            var x = new Money(25, CurrencyCode.XXX);
            var y = new Money(2, CurrencyCode.XXX);

            var expected = new Money(50, CurrencyCode.XXX);

            var actual = x * y;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Money_divide_operator_should_divide_two_Money_objects_correctly()
        {
            var x = new Money(25, CurrencyCode.XXX);
            var y = new Money(5, CurrencyCode.XXX);

            var expected = new Money(5, CurrencyCode.XXX);

            var actual = x / y;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Addition_of_two_Money_objects_with_different_CurrencyCode_should_rise_InvalidOperationException()
        {
            var x = new Money(10, CurrencyCode.XXX);
            var y = new Money(10, CurrencyCode.EUR);

            var result = x + y;
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Substraction_of_two_Money_objects_with_different_CurrencyCode_should_rise_InvalidOperationException()
        {
            var x = new Money(10, CurrencyCode.XXX);
            var y = new Money(10, CurrencyCode.EUR);

            var result = x - y;
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Multiplication_of_two_Money_objects_with_different_CurrencyCode_should_rise_InvalidOperationException()
        {
            var x = new Money(10, CurrencyCode.XXX);
            var y = new Money(10, CurrencyCode.EUR);

            var result = x * y;
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Division_of_two_Money_objects_with_different_CurrencyCode_should_rise_InvalidOperationException()
        {
            var x = new Money(10, CurrencyCode.XXX);
            var y = new Money(10, CurrencyCode.EUR);

            var result = x / y;
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
