using System;
using NosSharp.SDK.Enums.Inventory.Items;

namespace NosSharp.SDK.GameObjects.Items.Instance
{
    public class ItemInstance
    {
        public Guid Id { get; set; }

        public Item Item { get; set; }

        public RarityType Rarity { get; set; }

        public UpgradeType Upgrade { get; set; }

        public byte Slot { get; set; }
    }
}