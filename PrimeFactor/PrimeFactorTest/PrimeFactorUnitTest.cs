using System.Collections.Generic;
using NUnit.Framework;
using PrimeFactorsService;

namespace PrimeFactorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OneShouldReturn_NoPrimeFactors()
        {
            List<int> primeFactors = PrimeFactors.Calculate(1);

            Assert.That(primeFactors, Is.Empty);
        }

        [Test]
        public void TwoShouldReturn_Two()
        {
            List<int> primeFactors = PrimeFactors.Calculate(2);
            List<int> expectedValue = new List<int> { 2 };

            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }

        [Test]
        public void ThreeShouldReturn_Three()
        {
            List<int> primeFactors = PrimeFactors.Calculate(3);
            List<int> expectedValue = new List<int> { 3 };

            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }
    }
}