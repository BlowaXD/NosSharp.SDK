using System;

namespace NosSharp.SDK.Packets.Serialization
{
    public interface IPacket
    {
        Type Type { get; }
        string OriginalContent { get; set; }

        string OriginalHeader { get; set; }
    }
}