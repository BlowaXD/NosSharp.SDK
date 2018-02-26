using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using NosSharp.SDK.Enums.InventoryType;
using NosSharp.SDK.GameObjects.Item.Instance;

namespace NosSharp.SDK.GameObjects.Inventory
{
    public class Inventory : ConcurrentDictionary<Guid, ItemInstance>
    {
        #region Members

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

        public void GetItemFromVnum(short vNum)
        {

        }

        public void GetItemFromItemInstanceId(Guid id)
        {

        }

        public ItemInstance LoadByItemInstance(Guid id)
        {
            return null;
        }

        public ItemInstance LoadBySlotAndType(short slot, InventoryType type)
        {
            return null;
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