// NosSharp
// AuctionDto.cs

using System;

namespace NosSharp.SDK.DTO
{
    public class AuctionDto
    {
        public Guid Id { get; set; }

        public int CharacterId { get; set; }
        public DateTime StartDate { get; set; }

        public ItemInstanceDto Item { get; set; }

        public int Price { get; set; }

        public int Charge { get; set; }
    }
}