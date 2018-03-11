// NosSharp
// CharacterDto.cs

using NosSharp.SDK.Enums.Character;

namespace NosSharp.SDK.DTO
{
    /// <summary>
    /// Character that is used to be transfered between different implementation (Data Transfer Object)
    /// </summary>
    public class CharacterDto
    {
        /// <summary>
        /// CharacterId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// AccountId that owns the Character
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// Player Slot
        /// </summary>
        public PlayerSlotType Slot { get; set; }

        /// <summary>
        /// Gender of the Character (Male, Female)
        /// </summary>
        public GenderType Gender { get; set; }

        /// <summary>
        /// Hair Color style
        /// </summary>
        public HairColorType HairColor { get; set; }

        public HairStyleType HairType { get; set; }

        public string Name { get; set; }


        /*
         * LEVELS
         */
        public short Level { get; set; }
        public int LevelXp { get; set; }

        public short JobLevel { get; set; }
        public int JobLevelXp { get; set; }

        public short HeroLevel { get; set; }
        public int HeroLevelXp { get; set; }

        public int Reputation { get; set; }
        public int Compliment { get; set; }
        public byte Dignity { get; set; }

        public CharacterStatsDto Stats { get; set; }
    }
}