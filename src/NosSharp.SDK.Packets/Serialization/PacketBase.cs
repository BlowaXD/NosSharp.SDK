namespace NosSharp.SDK.Packets.Serialization
{
    public abstract class PacketBase : IPacket
    {
        public string OriginalContent { get; set; }
        public string OriginalHeader { get; set; }
    }
}