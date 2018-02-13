using System;
using NosSharp.SDK.Enumerations.Inventory;

namespace NosSharp.SDK.Components.Inventory
{
    public class ItemInstance
    {
        /// <summary>
        /// ItemInstance Guid
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// ItemType
        /// </summary>
        public ItemType ItemType { get; set; }

        public byte Upgrade { get; set; }
        public byte Rarity { get; set; }

        /// <summary>
        /// Item Vnum
        /// </summary>
        public ushort VNum { get; set; }

        public byte Slot { get; set; }

        public InventoryType InventoryType { get; set; }
    }
}