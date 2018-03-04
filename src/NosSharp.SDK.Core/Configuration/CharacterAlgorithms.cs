using System.Collections.Generic;
using NosSharp.SDK.Enums.Character;

namespace NosSharp.SDK.Core.Configuration
{
    public class CharacterAlgorithms
    {
        /// <summary>
        /// Hp & Mp
        /// </summary>
        public Dictionary<ClassType, Dictionary<int, int>> Hp { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> HpRegen { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> HpRegenStand { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> Mp { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> MpRegenStand { get; set; }

        /// <summary>
        /// Combat Stats
        /// </summary>
        public Dictionary<ClassType, Dictionary<int, int>> CriticalDistance { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> CriticalDistanceRate { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> CriticalClose { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> CriticalCloseRate { get; set; }


        public Dictionary<ClassType, Dictionary<int, int>> DistanceDefence { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> DistanceDodge { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> DistanceRate { get; set; }


        public Dictionary<ClassType, Dictionary<int, int>> CloseDefence { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> CloseDodge { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> CloseRate { get; set; }

        public Dictionary<ClassType, Dictionary<int, int>> MagicalDefence { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> MaxHit { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> MinDistance { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> MaxDistance { get; set; }

        /// <summary>
        /// Resistances
        /// </summary>
        public Dictionary<ClassType, Dictionary<int, int>> DarkResistance { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> LightResistance { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> FireResistance { get; set; }
        public Dictionary<ClassType, Dictionary<int, int>> WaterResistance { get; set; }

        public Dictionary<ClassType, byte> Speed { get; set; }

        public Dictionary<byte, int> LevelXp { get; set; }
        public Dictionary<byte, int> JobXp { get; set; }
        public Dictionary<byte, int> HeroXp { get; set; }
    }
}