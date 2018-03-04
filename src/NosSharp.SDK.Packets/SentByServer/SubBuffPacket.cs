// NosSharp
// SubBuffPacket.cs

using NosSharp.SDK.Packets.Serialization;

namespace NosSharp.SDK.Packets.SentByServer
{
    [PacketHeader("sub_buff")]
    public class BuffSubPacket : PacketBase
    {
        public BuffSubPacket() : base(typeof(BuffSubPacket))
        {
        }

        [PacketIndex(0)]
        public int Value { get; set; } // uses left of buff, used for example for rarifying

        [PacketIndex(1)]
        public int BuffId { get; set; }

        [PacketIndex(2)]
        public int Duration { get; set; } // divided by 10
    }
}