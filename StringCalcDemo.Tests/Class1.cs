using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Core;
using NUnit.Framework;
using StringCalcDemo;

namespace StringCalcDemo.Tests
{
    [TestFixture]
    public class StringCalcDemoTests
    {
        [Test]
        [TestCase("", Result= 0)]
        [TestCase("1%2", Result = 3)]
        public int TestForEmptyString(string numbers)
        {
            var calc = new Calc();
            return calc.Add(numbers);
        }

        [Test]
        public void TestForOneNumber()
        {
            var calc = new Calc();
            Assert.AreEqual(calc.Add("3"), 3);
        }

        [Test]
        [TestCase("1,2", Result = 3)]
        public int TestForTwoNumbers(string numbers)
        {
            var calc = new Calc();
            return calc.Add(numbers);
        }

        [Test]
        [TestCase("1\n2", Result = 3)]
        public int TestForLineBreaks(string numbers)
        {
            var calc = new Calc();
            return calc.Add(numbers);
        }


        [Test]
        [TestCase("1+2", Result = 3)]
        public int TestForPlusSign(string numbers)
        {
            var calc = new Calc();
            return calc.Add(numbers);
        }


        [Test]
        [TestCase("-1+2", ExpectedException = typeof(System.Exception) , ExpectedMessage= "You entered -1.Negatives are not allowed")]
        public int TestForNegatives(string numbers)
        {
            var calc = new Calc();
            return calc.Add(numbers);
        }

        [Test]
        [TestCase("-1+-2", ExpectedException = typeof(System.Exception), ExpectedMessage = "You entered -1,-2.Negatives are not allowed")]
        public int TestForMultipleNegatives(string numbers)
        {
            var calc = new Calc();
            return calc.Add(numbers);
        }

        [TestCase("1001+2", Result = 2)]
        public int TestForOverThousand(string numbers)
        {
            var calc = new Calc();
            return calc.Add(numbers);
        }



        [TestCase("1\n\n2", Result = 3)]
        public int TestForMultipleLineBreaks(string numbers)
        {
            var calc = new Calc();
            return calc.Add(numbers);
        }
    }
}
