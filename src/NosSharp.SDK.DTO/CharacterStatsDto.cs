// NosSharp
// CharacterStatsDto.cs

namespace NosSharp.SDK.DTO
{
    public class CharacterStatsDto
    {
        /*
         * PVE
         */
        public int PveKill { get; set; }
        public int PveHit { get; set; }
        public int PveHitReceived { get; set; }
        public int PveDeath { get; set; }
        public int GoldFarmed { get; set; }
        public int ReputationFarmed { get; set; }

        
        /*
         * PVP
         */
        public int PvpKill { get; set; }
        public int Pvphit { get; set; }
        public int PvpHitReceived { get; set; }
        public int PvpDeath { get; set; }

        /*
         * ARENA
         */
        public int ArenaKill { get; set; }
        public int ArenaHit { get; set; }
        public int ArenaHitReceived { get; set; }
        public int ArenaDeath { get; set; }

        /*
         * ACT 4
         */
        public int Act4Kill { get; set; }
        public int Act4Hit { get; set; }
        public int Act4HitReceived { get; set; }
        public int Act4Death { get; set; }
    }
}