// NosSharp
// IAuctionService.cs

using System;
using System.Collections;
using System.Collections.Generic;
using NosSharp.SDK.DTO;
using NosSharp.SDK.Enums.Auction;

namespace NosSharp.SDK.DAL.Interfaces
{
    public interface IAuctionService
    {
        void Add(AuctionDto auction);
        void Add(AuctionDto[] aucions);
        void Add(IEnumerable<AuctionDto> auctions);

        void Remove(AuctionDto auction);
        void Remove(AuctionDto[] auctions);
        void Remove(IEnumerable<AuctionDto> auctions);

        void Remove(Guid auctionId);
        void Remove(Guid[] auctionsIds);
        void Remove(IEnumerable<Guid> auctionIds);

        IEnumerable<AuctionDto> LoadAll();
        IEnumerable<AuctionDto> LoadByCategory(AuctionCategory auctionCategory);
        IEnumerable<AuctionDto> LoadBySearch(string searchPattern);
        IEnumerable<AuctionDto> LoadByCharacterId(int characterId);
        IEnumerable<AuctionDto> LoadByAccountId(int accountId);
    }
}