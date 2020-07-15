using Bissextile;
using NUnit.Framework;
using System;

namespace BissextileTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(-20)]
        [TestCase(100)]
        [TestCase(1)]
        [TestCase(1)]
        [TestCase(1)]
        [TestCase(1)]
        public void ShouldReturn_False(int year)
        {
            Assert.That(BissextileServices.IsBissextile(year), Is.False);
        }

        [TestCase(4)]
        [TestCase(4)]
        [TestCase(4)]
        [TestCase(4)]
        [TestCase(4)]
        [TestCase(4)]
        [TestCase(4)]
        public void ShouldReturn_True(int year)
        {
            Assert.That(BissextileServices.IsBissextile(year), Is.True);
        }

        [Test]
        public void ShouldReturnException()
        {
            try
            {
                BissextileServices.IsBissextile(0);
            }
            catch (InvalidOperationException)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}