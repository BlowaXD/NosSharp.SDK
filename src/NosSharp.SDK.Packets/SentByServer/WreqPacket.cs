using NosSharp.SDK.Packets.Serialization;

namespace NosSharp.SDK.Packets.SentByServer
{
    [PacketHeader("wreq")]
    [PacketPropertySplitter(' ')]
    public class WreqPacket : PacketBase
    {
        public WreqPacket() : base(typeof(WreqPacket))
        {

        }

        #region Properties

        [PacketIndex(1)]
        public long? Param { get; set; }

        [PacketIndex(0)]
        public byte Value { get; set; }

        #endregion
    }
}