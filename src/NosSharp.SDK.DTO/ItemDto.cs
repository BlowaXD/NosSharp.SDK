// NosSharp
// ItemDto.cs

using NosSharp.SDK.Enums.Inventory;

namespace NosSharp.SDK.DTO
{
    public class ItemDto
    {
        public int Vnum { get; set; }

        public InventoryType InventoryType;
    }
}