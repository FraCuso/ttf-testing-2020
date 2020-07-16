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

        [Test]
        public void ShouldAcceptString_AndReturn_int()
        {
            var test = StringCalculator.Add("hey");

            Assert.That(test is int);
        }

        [Test]
        public void ShouldAcceptEmptyString_AndReturn_0()
        {
            var test = StringCalculator.Add("");

            Assert.That(test, Is.EqualTo(0));
        }

        [Test]
        public void ShouldAcceptStringWithNumber_AndReturn_Number()
        {
            var test = StringCalculator.Add("74");

            Assert.That(test, Is.EqualTo(74));
        }

    }
}