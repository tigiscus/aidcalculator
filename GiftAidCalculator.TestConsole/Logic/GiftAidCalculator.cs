using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.TestConsole.Logic
{
    public class GiftAidCalculator : IGiftAidCalculator
    {
        public decimal Calculate(decimal donation)
        {
            var ratio = 20m / (100 - 20m);
            var result = donation * ratio;
            return donation + result;
        }
    }
}
