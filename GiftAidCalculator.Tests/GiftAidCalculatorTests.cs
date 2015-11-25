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
            var giftAidCalculator = new GiftAidCalculatorFixture().SetupTaxRate().Create();

            //act
            var result = giftAidCalculator.Calculate(donation);

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(100, 20, 125)]
        [TestCase(100, 50, 200)]
        public void Story2(decimal donation, decimal taxRate, decimal expectedResult)
        {
            //arrange
            var giftAidCalculator = new GiftAidCalculatorFixture().SetupTaxRate(taxRate).Create();

            //act
            var result = giftAidCalculator.Calculate(donation);

            //assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
