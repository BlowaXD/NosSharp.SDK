using System;
using NosSharp.ECS.Components;
using NosSharp.SDK.Enumerations.Inventory;

namespace NosSharp.SDK.Components.Inventory
{
    public class ItemComponent : IComponent
    {
        public Type Type => typeof(ItemComponent);

        /// <summary>
        /// ItemType
        /// </summary>
        public ItemType ItemType { get; set; }
        
        /// <summary>
        /// Item Vnum
        /// </summary>
        public ushort VNum { get; set; }

        public InventoryType InventoryType { get; set; }
    }
}