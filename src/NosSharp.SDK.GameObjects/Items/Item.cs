// NosSharp
// Item.cs

using NosSharp.SDK.Enums.Inventory;

namespace NosSharp.SDK.GameObjects.Items
{
    public class Item
    {
        public short VNum { get; set; }

        public InventoryType InventoryType { get; set; }
    }
}