using GiftAidCalculator.TestConsole.Repositories;
using GiftAidCalculator.Tests.Extensions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.Tests.Fixture
{
    public class GiftAidCalculatorFixture
    {
        private readonly IGiftAidSettingsRepository settingsRepository;

        public GiftAidCalculatorFixture()
        {
            settingsRepository = new Mock<IGiftAidSettingsRepository>().Object;
        }

        public GiftAidCalculatorFixture SetupTaxRate(decimal rate = 20)
        {
            settingsRepository.AsMock().Setup(p => p.GetSettings()).Returns(new TestConsole.Models.GiftAidSettings() {
                TaxRate = rate
            });
            return this;
        }

        public TestConsole.Logic.GiftAidCalculator Create()
        {
            return new TestConsole.Logic.GiftAidCalculator(settingsRepository);
        }
    }
}
