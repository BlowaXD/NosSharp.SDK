using System;
using NosSharp.ECS.Components;

namespace NosSharp.SDK.Components.Inventory
{
    public class InventoryComponent : IComponent
    {
        public Type Type => typeof(InventoryComponent);
    }
}