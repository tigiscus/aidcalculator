using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.Tests.Fixture
{
    public class GiftAidCalculatorFixture
    {
        public TestConsole.Logic.GiftAidCalculator Create()
        {
            return new TestConsole.Logic.GiftAidCalculator();
        }
    }
}
