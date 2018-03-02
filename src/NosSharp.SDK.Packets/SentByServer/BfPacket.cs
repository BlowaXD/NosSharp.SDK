// NosSharp
// BfPacket.cs

using System.Collections.Generic;
using NosSharp.SDK.Packets.Serialization;

namespace NosSharp.SDK.Packets.SentByServer
{
    [PacketHeader("bf")]
    public class BfPacket
    {
        [PacketIndex(0)] public byte Type { get; set; }
        [PacketIndex(1)] public long CharacterId { get; set; }
        [PacketIndex(2)] public IEnumerable<BuffSubPacket> BuffEntries { get; set; }
        [PacketIndex(3)] public int CharacterLevel { get; set; }
    }
}