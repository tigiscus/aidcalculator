using GiftAidCalculator.TestConsole.Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.TestConsole.Models
{
    public class SupplementRule
    {
        public EventType EventType { get; set; }
        public decimal Rate { get; set; }
    }
}
