using NosSharp.SDK.Packets.Serialization;

namespace NosSharp.SDK.Packets.SentByClient
{
    [PacketHeader("Char_DEL")]
    public class CharacterDeletePacket : PacketBase
    {
        public CharacterDeletePacket() : base(typeof(CharacterDeletePacket))
        {
        }

        [PacketIndex(0)]
        public byte Slot { get; set; }

        [PacketIndex(1)]
        public string Password { get; set; }
    }
}