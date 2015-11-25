using GiftAidCalculator.TestConsole.Logic.Enums;
using GiftAidCalculator.TestConsole.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.TestConsole.Logic
{
    public class GiftAidCalculator : IGiftAidCalculator
    {
        private readonly IGiftAidSettingsRepository settingsRepository;

        public GiftAidCalculator(IGiftAidSettingsRepository settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public decimal Calculate(decimal donation, EventType eventType = EventType.None)
        {
            var settings = settingsRepository.GetSettings();
            var taxRate = settings.TaxRate;
            var ratio = taxRate / (100 - taxRate);
            var result = donation * ratio;
            return Math.Round(donation + result, 2);
        }
    }
}
