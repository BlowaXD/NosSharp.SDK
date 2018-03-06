// NosSharp.SDK
// RatesConfiguration.cs

namespace NosSharp.SDK.Core.Configuration
{
    public class RatesConfiguration
    {
        public int XpRate { get; set; }
        public int JobXpRate { get; set; }
        public int HeroXpRate { get; set; }

        public int DropRate { get; set; }
        public int DropRarityRate { get; set; }
        public int DropQuantityRate { get; set; }

        public int ReputationRate { get; set; }
        public bool ReputationOnKill { get; set; }

        public int UpgradeRate { get; set; }
        public int RarifyRate { get; set; }
    }
}