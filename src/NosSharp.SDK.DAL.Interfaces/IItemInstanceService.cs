// NosSharp
// IItemInstanceService.cs

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NosSharp.SDK.DTO;

namespace NosSharp.SDK.DAL.Interfaces
{
    public interface IItemInstanceService
    {
        void Add(ItemInstanceDto item);
        void Add(ItemInstanceDto[] items);
        void Add(IEnumerable<ItemInstanceDto> items);

        void Update(ItemInstanceDto item);
        void Update(ItemInstanceDto[] items);
        void Update(IEnumerable<ItemInstanceDto> item);

        void Remove(ItemInstanceDto item);
        void Remove(ItemInstanceDto[] items);
        void Remove(IEnumerable<ItemInstanceDto> items);
        void Remove(Guid id);
        void Remove(Guid[] ids);
        void Remove(IEnumerable<Guid> ids);

        ItemInstanceDto Get(Guid id);
        IEnumerable<ItemInstanceDto> GetByCharacterId(int characterId);
        IEnumerable<ItemInstanceDto> GetByAccountId(int accountId);
        IEnumerable<ItemInstanceDto> GetByPredicate(Expression<Func<bool>> predicate);
    }
}