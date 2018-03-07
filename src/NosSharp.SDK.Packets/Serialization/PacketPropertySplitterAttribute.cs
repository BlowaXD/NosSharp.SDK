// NosSharp
// PacketPropertySplitterAttribute.cs

using System;

namespace NosSharp.SDK.Packets.Serialization
{
    public class PacketPropertySplitterAttribute : Attribute
    {
        public PacketPropertySplitterAttribute(char separator)
        {
            Separator = separator;
        }
        
        public char Separator { get; }
    }
}