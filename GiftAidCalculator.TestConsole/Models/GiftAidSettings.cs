using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.TestConsole.Models
{
    public class GiftAidSettings
    {
        public decimal TaxRate { get; set; }
        public IEnumerable<SupplementRule> SupplementRules { get; set; }
    }
}
