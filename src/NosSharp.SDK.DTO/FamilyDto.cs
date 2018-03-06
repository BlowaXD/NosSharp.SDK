// NosSharp.SDK
// FamilyDto.cs

using System;
using NosSharp.SDK.Enums.Character;

namespace NosSharp.SDK.DTO
{
    public class FamilyDto
    {
        public Guid Id { get; set; }
        public FactionType Faction { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
        public DateTime CreationDate { get; set; }

        public int LeaderId { get; set; }
    }
}