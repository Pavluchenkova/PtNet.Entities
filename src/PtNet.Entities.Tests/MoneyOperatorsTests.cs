using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PtNet.Entities.Tests
{
    [TestClass]
    public class MoneyOperatorsTests
    {
        [TestMethod]
        public void Plus_operator_should_add_two_Money_objects_correctly()
        {
            var x = new Money(25, CurrencyCode.XXX);
            var y = new Money(15, CurrencyCode.XXX);

            var expected = new Money(40, CurrencyCode.XXX);

            var actual = x + y;

            Assert.AreEqual(expected.Amount, actual.Amount);
            Assert.AreEqual(expected.Currency, actual.Currency);
        }

        [TestMethod]
        public void Minus_operator_should_substract_two_Money_objects_correctly()
        {
            var x = new Money(25, CurrencyCode.XXX);
            var y = new Money(15, CurrencyCode.XXX);

            var expected = new Money(10, CurrencyCode.XXX);

            var actual = x - y;

            Assert.AreEqual(expected.Amount, actual.Amount);
            Assert.AreEqual(expected.Currency, actual.Currency);
        }

        [TestMethod]
        public void Multiply_operator_should_multiply_two_Money_objects_correctly()
        {
            var x = new Money(25, CurrencyCode.XXX);
            var y = new Money(2, CurrencyCode.XXX);

            var expected = new Money(50, CurrencyCode.XXX);

            var actual = x * y;

            Assert.AreEqual(expected.Amount, actual.Amount);
            Assert.AreEqual(expected.Currency, actual.Currency);
        }

        [TestMethod]
        public void Divide_operator_should_divide_two_Money_objects_correctly()
        {
            var x = new Money(25, CurrencyCode.XXX);
            var y = new Money(5, CurrencyCode.XXX);

            var expected = new Money(5, CurrencyCode.XXX);

            var actual = x / y;

            Assert.AreEqual(expected.Amount, actual.Amount);
            Assert.AreEqual(expected.Currency, actual.Currency);
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
        public void Equals_operator_should_return_true_for_objects_with_equal_amount_and_equal_currency()
        {
            var x = new Money(10, CurrencyCode.AED);
            var y = new Money(10, CurrencyCode.AED);
            var expected = true;
            var actual = x == y;
            Assert.AreEqual(expected, actual);       
        }
        [TestMethod]
        public void NotEquals_operator_should_return_true_for_objects_with_not_equal_amount()
        {
            var x = new Money(10, CurrencyCode.AED);
            var y = new Money(5, CurrencyCode.AED);
            var expected = true;
            var actual = x != y;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GreahterThan_operator_should_return_true_if_first_operands_amount_greahter_than_second_operands_amount()
        {
            var x = new Money(45, CurrencyCode.AED);
            var y = new Money(10, CurrencyCode.AED);
            var expected = true;
            var actual = x > y;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LessThan_operator_should_return_true_if_first_operands_amount_less_than_second_operands_amount()
        {
            var x = new Money(5, CurrencyCode.AED);
            var y = new Money(10, CurrencyCode.AED);
            var expected = true;
            var actual = x < y;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GreatherThanOrEquals_operator_should_return_true_if_first_operands_amount_greather_than_second_operands_amount()
        {
            var x = new Money(10, CurrencyCode.AED);
            var y = new Money(5, CurrencyCode.AED);

            var expected = true;
            var actual = x >= y;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreatherThanOrEquals_operator_should_return_true_if_first_operands_amount_equals_to_second_operands_amount()
        {
            var x = new Money(10, CurrencyCode.AED);
            var y = new Money(10, CurrencyCode.AED);

            var expected = true;
            var actual = x >= y;
            Assert.AreEqual(expected, actual);
        }
               
        [TestMethod]
        public void LessThanOrEquals_operator_should_return_true_if_first_operands_amount_less_than_second_operands_amount()
        {
            var x = new Money(5, CurrencyCode.AED);
            var y = new Money(10, CurrencyCode.AED);

            var expected = true;
            var actual = x <= y;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LessThanOrEquals_operator_should_return_true_if_first_operands_amount_equals_to_second_operands_amount()
        {
            var x = new Money(10, CurrencyCode.AED);
            var y = new Money(10, CurrencyCode.AED);
            var expected = true;
            var actual = x >= y;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Equals_operator_should_return_false_for_objects_with_not_equal_amount_and_equal_currency()
        {
            var x = new Money(5, CurrencyCode.AED);
            var y = new Money(10, CurrencyCode.AED);
            var expected = false;
            var actual = x == y;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotEquals_operator_should_return_false_for_objects_with_equal_amount()
        {
            var x = new Money(10, CurrencyCode.AED);
            var y = new Money(10, CurrencyCode.AED);
            var expected = false;
            var actual = x != y;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EqualsOperator_should_return_false_if_one_of_operands_is_null()
        {
            Money x = null;
            var y = new Money(10, CurrencyCode.AED);
        
            var expected = false;
            var actual = x == y;        
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotEqualsOperator_should_return_false_if_one_of_operands_is_null()
        {
            Money x = null;
            var y = new Money(10, CurrencyCode.AED);
            
            var expected = false;
            var actual = x != y;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreatherThanOperator_should_return_false_if_one_of_operands_is_null()
        {
            Money x = null;
            var y = new Money(10, CurrencyCode.AED);

            var expected = false;
            var actual = x > y;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LessThanOperator_should_return_false_if_one_of_operands_is_null()
        {
            Money x = null;
            var y = new Money(10, CurrencyCode.AED);
           
            var expected = false;
            var actual = x < y;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreatherOrEqualsOperator_should_return_false_if_one_of_operands_is_null()
        {
            Money x = null;
            var y = new Money(10, CurrencyCode.AED);
           
            var expected = false;
            var actual = x >= y;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LessOrEqualsOperator_should_return_false_if_one_of_operands_is_null()
        {
            Money x = null;
            var y = new Money(10, CurrencyCode.AED);
           
            var expected = false;
            var actual = x <= y;
            Assert.AreEqual(expected, actual);
        }
    }
}
