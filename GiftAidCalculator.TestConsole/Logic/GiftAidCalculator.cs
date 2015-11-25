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

        public decimal Calculate(decimal donation)
        {
            var settings = settingsRepository.GetSettings();
            var taxRate = settings.TaxRate;
            var ratio = taxRate / (100 - taxRate);
            var result = donation * ratio;
            return donation + result;
        }
    }
}
