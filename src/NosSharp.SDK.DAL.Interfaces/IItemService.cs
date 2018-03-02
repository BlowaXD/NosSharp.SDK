// NosSharp
// IItemService.cs

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NosSharp.SDK.DTO;

namespace NosSharp.SDK.DAL.Interfaces
{
    public interface IItemService
    {
        void Add(ItemDto itemDto);
        void Add(ItemDto[] itemsDto);
        void Add(IEnumerable<ItemDto> items);

        void Update(ItemDto itemDto);
        void Update(ItemDto[] itemsDto);
        void Update(IEnumerable<ItemDto> items);

        ItemDto LoadByVnum(int vnum);
        ItemDto Single(string key);
        
        IEnumerable<ItemDto> LoadAll();
        IEnumerable<ItemDto> LoadWhere(Expression<Func<bool>> predicate);
    }
}