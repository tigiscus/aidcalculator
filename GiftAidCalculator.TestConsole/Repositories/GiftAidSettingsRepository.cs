using GiftAidCalculator.TestConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.TestConsole.Repositories
{
    public class GiftAidSettingsRepository : IGiftAidSettingsRepository
    {
        public GiftAidSettings GetSettings()
        {
            //data should be selected from some data store 
            return new GiftAidSettings() {
                TaxRate = 20
            };
        }
    }
}
