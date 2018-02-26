namespace NosSharp.SDK.Packets.Serialization
{
    public interface IPacket
    {
        string OriginalContent { get; set; }

        string OriginalHeader { get; set; }
    }
}