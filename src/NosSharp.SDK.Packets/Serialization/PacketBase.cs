using System;

namespace NosSharp.SDK.Packets.Serialization
{
    public abstract class PacketBase : IPacket
    {
        protected PacketBase(Type type) => Type = type;

        public Type Type { get; }
        public string OriginalContent { get; set; }
        public string OriginalHeader { get; set; }
    }
}