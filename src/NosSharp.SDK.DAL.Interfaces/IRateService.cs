// NosSharp.SDK
// IRateService.cs

namespace NosSharp.SDK.DAL.Interfaces
{
    public interface IRateService
    {
        int XpRate { get; }
        int JobXpRate { get; }
        int HeroXpRate { get; }

        int DropRate { get; }
        int DropRarityRate { get; }
        int DropQuantityRate { get; }

        int ReputationRate { get; }
        bool ReputationOnKill { get; }

        int UpgradeRate { get; }
        int RarifyRate { get; }

        void Update();
    }
}