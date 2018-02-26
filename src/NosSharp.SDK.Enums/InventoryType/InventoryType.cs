﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NosSharp.SDK.Enums.InventoryType
{
    public enum InventoryType : byte
    {
        Equipment = 0,
        Main = 1,
        Etc = 2,
        Miniland = 3,
        Specialist = 6,
        Costume = 7,
        Wear = 8,
        Bazaar = 9,
        Warehouse = 10,
        FamilyWareHouse = 11,
        PetWarehouse = 12,
        FirstPartnerInventory = 13,
        SecondPartnerInventory = 14,
        ThirdPartnerInventory = 15,
    }
}