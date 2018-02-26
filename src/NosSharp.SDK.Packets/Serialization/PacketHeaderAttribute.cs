using System;
using NosSharp.SDK.Enums;

namespace NosSharp.SDK.Packets.Serialization
{
    public class PacketHeaderAttribute : Attribute
    {

        public PacketHeaderAttribute(string header) => Header = header;

        #region Properties

        /// <summary>
        /// Permission to handle the packet
        /// </summary>
        public AuthorityType Authority { get; set; }

        /// <summary>
        /// Unique identification of the Packet
        /// </summary>
        public string Header { get; }

        /// <summary>
        /// Pass the packet to handler method even if the serialization has failed.
        /// </summary>
        public bool PassNonParseablePacket { get; set; }

        #endregion
    }
}
