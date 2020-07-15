using System;
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
        [Test]
        public void FourShouldReturn_TwoTwo()
        {
            List<int> primeFactors = PrimeFactors.Calculate(4);
            List<int> expectedValue = new List<int> { 2 , 2 };

            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }
        [Test]
        public void FiveShouldReturn_Five()
        {
            List<int> primeFactors = PrimeFactors.Calculate(5);
            List<int> expectedValue = new List<int> { 5 };

            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }
        [Test]
        public void SixShouldReturn_TwoThree()
        {
            List<int> primeFactors = PrimeFactors.Calculate(6);
            List<int> expectedValue = new List<int> { 2, 3 };

            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }

        [Test]
        public void SevenShouldReturn_Seven()
        {
            List<int> primeFactors = PrimeFactors.Calculate(7);
            List<int> expectedValue = new List<int> { 7 };

            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }

        [Test]
        public void EightShouldReturn_TwoTwoTwo()
        {
            List<int> primeFactors = PrimeFactors.Calculate(8);
            List<int> expectedValue = new List<int> { 2, 2, 2 };

            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }
        [Test]
        public void NineShouldReturn_ThreeThree()
        {
            List<int> primeFactors = PrimeFactors.Calculate(9);
            List<int> expectedValue = new List<int> { 3, 3 };

            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }
        [Test]
        public void TenShouldReturn_TwoFive()
        {
            List<int> primeFactors = PrimeFactors.Calculate(10);
            List<int> expectedValue = new List<int> { 2, 5};

            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }
        [Test]
        public void ShouldReturn_Five_TwoHundredSixtyNine()
        {
            List<int> primeFactors = PrimeFactors.Calculate(1345);
            List<int> expectedValue = new List<int> { 5, 269 };

            Assert.That(primeFactors, Is.EqualTo(expectedValue));
        }
        [Test]
        public void ShouldReturnException()
        {
            try
            {
                List<int> primeFactors = PrimeFactors.Calculate(-1);
            }
            catch (InvalidOperationException)
            {
                Assert.Pass();
            }
            Assert.Fail();            
        }
        [Test]
        public void Zero_ShouldReturnException()
        {
            Assert.That(()=>PrimeFactors.Calculate(0), Throws.InvalidOperationException);
        }
    }
}