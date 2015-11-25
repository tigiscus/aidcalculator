using GiftAidCalculator.TestConsole.Logic.Enums;
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
        //test cases for story 2
        [TestCase(100, 20, 125)]
        [TestCase(100, 50, 200)]
        //test cases for story 3
        [TestCase(100, 40, 166.67)]
        public void Story2And3(decimal donation, decimal taxRate, decimal expectedResult)
        {
            //arrange
            var giftAidCalculator = new GiftAidCalculatorFixture().SetupTaxRate(taxRate).Create();

            //act
            var result = giftAidCalculator.Calculate(donation);

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(100, 20, EventType.Running, EventType.Running, 5, 130)]
        [TestCase(100, 20, EventType.Swimming, EventType.Swimming, 3, 128)]
        [TestCase(100, 20, EventType.None, EventType.None, 0, 125)]
        [TestCase(100, 20, EventType.None, null, null, 125)]
        public void Story4(decimal donation, decimal taxRate, EventType selectedEventType, EventType? eventType, decimal supplementRate, decimal expectedResult)
        {
            //arrange
            var fixture = new GiftAidCalculatorFixture().SetupTaxRate(taxRate);
            if(eventType.HasValue)
                fixture.SetupRule(eventType.Value, supplementRate);

            var giftAidCalculator = fixture.Create();

            //act
            var result = giftAidCalculator.Calculate(donation, selectedEventType);

            //assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
