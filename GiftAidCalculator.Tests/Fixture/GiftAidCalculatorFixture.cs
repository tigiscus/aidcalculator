using GiftAidCalculator.TestConsole.Logic.Enums;
using GiftAidCalculator.TestConsole.Models;
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
        private readonly List<SupplementRule> rules;
        private GiftAidSettings settings;
        public GiftAidCalculatorFixture()
        {
            settingsRepository = new Mock<IGiftAidSettingsRepository>().Object;
            rules = new List<SupplementRule>();
            settings = new GiftAidSettings() { SupplementRules = rules };
            settingsRepository.AsMock().Setup(p => p.GetSettings()).Returns(settings);
        }

        public GiftAidCalculatorFixture SetupTaxRate(decimal rate = 20)
        {
            settings.TaxRate = rate;
            return this;
        }

        public GiftAidCalculatorFixture SetupRule(EventType e, decimal r)
        {
            rules.Add(new SupplementRule() { EventType = e, Rate = r });
            return this;
        }

        public TestConsole.Logic.GiftAidCalculator Create()
        {
            return new TestConsole.Logic.GiftAidCalculator(settingsRepository);
        }
    }
}
