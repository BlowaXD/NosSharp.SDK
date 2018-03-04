// NosSharp
// AddObjPacket.cs

using NosSharp.SDK.Packets.Serialization;

namespace NosSharp.SDK.Packets.SentByClient
{
    /// <summary>
    /// This packet is sent by client when he wants to place an object on his miniland
    /// </summary>
    [PacketHeader("addobj")]
    public class AddobjPacket : PacketBase
    {
        public AddobjPacket() : base(typeof(AddobjPacket))
        {
        }

        #region Properties

        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public short PositionX { get; set; }

        [PacketIndex(2)]
        public short PositionY { get; set; }

        #endregion
    }
}