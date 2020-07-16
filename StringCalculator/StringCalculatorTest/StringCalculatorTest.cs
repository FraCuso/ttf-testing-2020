using System;
using NUnit.Framework;
using StringCalculatorService;

namespace StringCalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("hey!!")]
        [TestCase("ftrygudinfhomklmdniudsjcdvfbdgnmfd  agba2e45t 4y5hetdgx ")]
        [TestCase("the quick brown fox jumps over the lazy dog")]
        [TestCase("1234567")]
        public void ShouldAcceptString_AndReturn_int(string s)
        {
            var test = StringCalculator.Add(s);

            Assert.That(test is int);
        }

        [TestCase("")]
        public void ShouldAcceptEmptyString_AndReturn_0(string s)
        {
            var test = StringCalculator.Add(s);

            Assert.That(test, Is.EqualTo(0));
        }

        [TestCase("74")]
        [TestCase("623")]
        [TestCase("11")]
        [TestCase("983241")]
        public void ShouldAcceptStringWithNumber_AndReturn_Number(string n)
        {
            var test = StringCalculator.Add(n);

            Assert.That(test, Is.EqualTo(Int32.Parse(n)));
        }

        [TestCase("1,2", 3)]
        [TestCase("1,3", 4)]
        [TestCase("14, 442", 456)]
        [TestCase("11, 74", 85)]
        public void ShouldAcceptStringWithNumberAndComma_AndReturn_Sum(string s, int ris)
        {
            var test = StringCalculator.Add(s);

            Assert.That(test, Is.EqualTo(ris));
        }

        [TestCase("54, 32, 1", 87)]
        [TestCase("1, 1, 1, 1, -1, 1, -1, 1", 4)]
        [TestCase("23, 87, 100, 10000", 10210)]
        public void ShouldAcceptStringWithMoreNumbersAndCommas_AndReturn_Sum(string s, int ris)
        {
            var test = StringCalculator.Add(s);

            Assert.That(test, Is.EqualTo(ris));
        }

        [TestCase("1\n2,3\n4", 10)]
        [TestCase("0,3\n14", 17)]
        [TestCase("66\n1,2\n23", 92)]
        [TestCase("14,1\n-4", 11)]
        public void ShouldAcceptStringWithMoreNumbersAndMoreSeparatoesAnd_AndReturn_Sum(string s, int ris)
        {
            var test = StringCalculator.Add(s);

            Assert.That(test, Is.EqualTo(ris));
        }

        [TestCase("1//;\n2//;\n3//;\n4", 10)]
        public void ShouldAcceptStringWithMoreNumbersAndCustomizedSeparatorsAnd_AndReturn_Sum(string s, int ris)
        {
            var test = StringCalculator.Add(s);

            Assert.That(test, Is.EqualTo(ris));
        }
    }
}