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
        public void Test1()
        {
            var test = StringCalculator.Add("hey");

            
            Assert.That(test is int);
        }
    }
}