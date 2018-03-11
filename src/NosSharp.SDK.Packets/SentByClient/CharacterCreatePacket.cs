using NosSharp.SDK.Enums.Character;
using NosSharp.SDK.Packets.Serialization;

namespace NosSharp.SDK.Packets.SentByClient
{
    [PacketHeader("Char_NEW")]
    public class CharacterCreatePacket : PacketBase
    {
        public CharacterCreatePacket() : base(typeof(CharacterCreatePacket))
        {

        }
        #region Properties

        [PacketIndex(0)]
        public string Name { get; set; }

        [PacketIndex(1)]
        public PlayerSlotType Slot { get; set; }

        [PacketIndex(2)]
        public GenderType Gender { get; set; }

        [PacketIndex(3)]
        public HairStyleType HairStyle { get; set; }

        [PacketIndex(4)]
        public HairColorType HairColor { get; set; }

        #endregion
    }
}