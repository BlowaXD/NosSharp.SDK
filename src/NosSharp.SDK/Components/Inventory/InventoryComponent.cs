using System;
using System.Collections.Generic;
using System.Linq;
using MMOS.ECS.Components;
using NosSharp.SDK.Enumerations.Inventory;

namespace NosSharp.SDK.Components.Inventory
{
    public class InventoryComponent : IComponent
    {
        private readonly Dictionary<Guid, ItemInstance> _itemsByGuid = new Dictionary<Guid, ItemInstance>();
        private readonly Dictionary<InventoryType, List<ItemInstance>> _items = new Dictionary<InventoryType, List<ItemInstance>>();

        public Type Type => typeof(InventoryComponent);

        #region Events

        /// <summary>
        /// Subscribe to this event if you want to be notified when Inventory is changed
        /// </summary>
        public event EventHandler InventoryChange;

        private void OnInventoryChange() => InventoryChange?.Invoke(this, EventArgs.Empty);

        #endregion

        public ItemInstance Get(InventoryType invType, byte slot)
        {
            return !_items.TryGetValue(invType, out List<ItemInstance> tmp) ? null : tmp.FirstOrDefault(s => s.Slot == slot);
        }


        public ItemInstance Get(Guid id)
        {
            return !_itemsByGuid.TryGetValue(id, out ItemInstance tmp) ? null : tmp;
        }

        public void Move(ItemInstance item)
        {
            if (item == null)
            {
                return;
            }

            OnInventoryChange();
        }

        public void Delete(ItemInstance item)
        {
            if (item == null)
            {
                return;
            }

            _itemsByGuid.Remove(item.Id);
            if (_items.TryGetValue(item.InventoryType, out List<ItemInstance> tmp))
            {
                OnInventoryChange();
                return;
            }
            OnInventoryChange();
        }

        public void Add(ItemInstance item)
        {
            if (item == null)
            {
                return;
            }
            
            OnInventoryChange();
        }
    }
}