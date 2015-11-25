using GiftAidCalculator.TestConsole.Logic.Enums;

namespace GiftAidCalculator.TestConsole.Logic
{
    public interface IGiftAidCalculator
    {
        decimal Calculate(decimal donation, EventType eventType = EventType.None);
    }
}