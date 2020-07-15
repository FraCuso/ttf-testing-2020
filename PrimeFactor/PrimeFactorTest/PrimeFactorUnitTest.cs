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
    }
}