using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using Parity.Library;

namespace ParityNUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(3)]
        public void IsEven_ShouldReturnTrue_WhenNumberIsOdd(int number) 
        {
            bool isEven = ParityService.IsOdd(number);

            Assert.That(isEven, Is.True);
        }

        [TestCase(2)]
        [TestCase(4)]
        public void IsEven_ShouldReturnFalse_WhenNumberIsEven(int number)
        {
            bool isEven = ParityService.IsOdd(number);

            Assert.That(isEven, Is.False);
        }


        //[Test]
        //public void IsEven_ShouldReturnTrue_WhenNumberIsOne()
        //{
        //    bool isEven = ParityService.IsOdd(1);

        //    Assert.That(isEven, Is.True);
        //}

        //[Test]
        //public void IsEven_ShouldReturnFalse_WhenNumberIsTwo() 
        //{
        //    bool isEven = ParityService.IsOdd(2);

        //Assert.That(isEven, Is.False);
        //}
        //[Test]
        //public void IsEven_ShouldReturnFalse_WhenNumberIsThree()
        //{
        //    bool isEven = ParityService.IsOdd(3);

        //    Assert.That(isEven, Is.True);
        //}

        //[Test]
        //public void IsEven_ShouldReturnFalse_WhenNumberIsFour()
        //{
        //    bool isEven = ParityService.IsOdd(4);

        //    Assert.That(isEven, Is.False);
        //}

    }
}