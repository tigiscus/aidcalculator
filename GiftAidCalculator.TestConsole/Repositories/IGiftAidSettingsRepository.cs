using GiftAidCalculator.TestConsole.Models;

namespace GiftAidCalculator.TestConsole.Repositories
{
    public interface IGiftAidSettingsRepository
    {
        GiftAidSettings GetSettings();
    }
}