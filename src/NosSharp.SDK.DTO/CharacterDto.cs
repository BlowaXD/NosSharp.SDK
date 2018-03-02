// NosSharp
// CharacterDto.cs

using NosSharp.SDK.Enums.Character;

namespace NosSharp.SDK.DTO
{
    public class CharacterDto
    {
        public int Id { get; set; }
        public int AccountId { get; set; }

        public PlayerSlotType Slot { get; set; }
        public GenderType Gender { get; set; }

        public string Name { get; set; }
        public CharacterStatsDto Stats { get; set; }
    }
}