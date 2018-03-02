// NosSharp
// ItemInstanceDto.cs

using System;
using System.Collections.Generic;

namespace NosSharp.SDK.DTO
{
    public class ItemInstanceDto
    {
        public Guid Id { get; set; }
        public ItemDto Item { get; set; }

        public int Quantity { get; set; }
        public int Rarity { get; set; }
        public int Upgrade { get; set; }

        public IEnumerable<ItemOptionDto> Options { get; set; }
    }
}