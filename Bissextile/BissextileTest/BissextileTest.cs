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
        [TestCase(1900)]
        [TestCase(1700)]
        [TestCase(31100)]
        [TestCase(1110)]
        [TestCase(666)]
        [TestCase(1709)]
        [TestCase(9999)]
        public void ShouldReturn_False(int year)
        {
            Assert.That(BissextileServices.IsBissextile(year), Is.False);
        }

        [TestCase(4)]
        [TestCase(800)]
        [TestCase(2000)]
        [TestCase(108)]
        [TestCase(34020)]
        [TestCase(1924)]
        [TestCase(2020)]
        [TestCase(4000)]
        [TestCase(11420)]
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