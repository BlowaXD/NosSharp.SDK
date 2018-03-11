// NosSharp
// ICharacterService.cs

using NosSharp.SDK.DTO;
using NosSharp.SDK.Enums.Character;

namespace NosSharp.SDK.DAL.Interfaces
{
    public interface ICharacterService
    {
        void Add(CharacterDto dto);
        void Add(CharacterDto[] dtos);

        void Update(CharacterDto dto);
        void Update(CharacterDto[] dto);

        void Delete(CharacterDto dto);
        void Delete(CharacterDto[] dtos);

        CharacterDto GetById(int id);
        CharacterDto GetByName(string name);

        CharacterDto[] GetByAccountId(int id);
        CharacterDto GetByAccountIdAndSlot(int id, PlayerSlotType slot);
        CharacterDto[] GetByAccountName(string name);
        CharacterDto GetByAccountNameAndSlot(string name, PlayerSlotType slot);

        CharacterDto[] GetTop();
        CharacterDto[] GetTop(int limitNumber);

        CharacterDto GetBaseCharacter();
    }
}