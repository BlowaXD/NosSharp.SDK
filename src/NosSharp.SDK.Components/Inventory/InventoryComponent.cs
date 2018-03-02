// NosSharp
// InventoryComponent.cs

using NosSharp.SDK.Components.Inventory.Args;
using NosSharp.SDK.Core.Utilities;

namespace NosSharp.SDK.Components.Inventory
{
    public class InventoryComponent
    {
        public static event TypedSenderEventHandler<InventoryComponent, InventoryChangeArgs> InventoryChanged;

        private void OnInventoryChanged(InventoryChangeArgs e) => InventoryChanged?.Invoke(this, e);
    }
}