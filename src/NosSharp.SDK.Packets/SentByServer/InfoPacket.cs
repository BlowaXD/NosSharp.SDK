using System;
using NosSharp.SDK.Packets.Serialization;

namespace NosSharp.SDK.Packets.SentByServer
{
    [PacketHeader("info")]
    public class InfoPacket : PacketBase
    {
        public InfoPacket() : base(typeof(InfoPacket))
        {
        }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}