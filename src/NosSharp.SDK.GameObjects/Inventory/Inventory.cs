using System;
using System.Collections.Generic;
using System.Linq;
using NosSharp.SDK.Enums.Inventory;
using NosSharp.SDK.GameObjects.Items;
using NosSharp.SDK.GameObjects.Items.Instance;

namespace NosSharp.SDK.GameObjects.Inventory
{
    public class Inventory
    {
        #region Members

        private Dictionary<Guid, ItemInstance> _itemInstancesByGuid;

        private Dictionary<InventoryType, ICollection<ItemInstance>> _itemInstancesByInventoryType;

        // To implement later, when database will be finished 
        private bool CanAddItem(short itemVnum) => false;

        #endregion

        #region Properties
        #endregion

        #region Methods

        public List<ItemInstance> AddItemToInventory(ItemInstance item, InventoryType type)
        {
            return null;
        }
        
        public List<ItemInstance> AddNewToInventory(InventoryType type, short vnum, byte amount = 1, sbyte rare = 0, short upgrade = 0, byte design = 0)
        {
            return null;
        }

        public ItemInstance AddToInventoryWithSlotAndType(ItemInstance itemInstance, InventoryType type, short slot)
        {
            return null;
        }

        public ItemInstance MoveItemInInventory(short sourceSlot, InventoryType sourceType, InventoryType targetType, short? targetSlot = null, bool wear = true)
        {
            return null;
        }

        public void RemoveItemFromInventory()
        {

        }

        public ItemInstance GetItemFromVnum(short vNum)
        {
            // Get this from StaticDataManager
            Item item = new Item();


            if (!_itemInstancesByInventoryType.TryGetValue(item.InventoryType, out ICollection<ItemInstance> itemInstances))
            {
                return null;
            }

            return itemInstances.FirstOrDefault(s => s.Item.VNum == vNum);
        }

        public ItemInstance GetItemFromItemInstanceId(Guid id)
        {
            return !_itemInstancesByGuid.TryGetValue(id, out ItemInstance instance) ? null : instance;
        }

        public ItemInstance GetBySlotAndType(short slot, InventoryType type)
        {
            return !_itemInstancesByInventoryType.TryGetValue(type, out ICollection<ItemInstance> itemInstances)
                ? null
                : itemInstances.FirstOrDefault(s => s.Slot == slot);
        }

        public Tuple<short, InventoryType> DeleteById(Guid id)
        {
            return null;
        }

        public void RemoveItemAmount(int vnum, int amount = 1)
        {

        }

        public void RemoveItemAmountFromInventory(byte amount, Guid id)
        {

        }

        public short? GetFreeSlot(InventoryType type, int hasBackPack)
        {
            return null;
        }

        public void DeleteItemFromSlotAndType()
        {

        }

        public int CountItemInInventory(short vNum)
        {
            return 0;
        }

        public int CountItem(short vNum)
        {
            return 0;
        }

        #endregion
    }
}