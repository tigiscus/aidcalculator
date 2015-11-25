using GiftAidCalculator.Tests.Fixture;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.Tests
{
    [TestFixture]
    public class GiftAidCalculatorTests
    {
        [Test]
        [TestCase(100, 125)]
        public void Story1(decimal donation, decimal expectedResult)
        {
            //arrange
            var giftAidCalculator = new GiftAidCalculatorFixture().Create();

            //act
            var result = giftAidCalculator.Calculate(donation);

            //assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
