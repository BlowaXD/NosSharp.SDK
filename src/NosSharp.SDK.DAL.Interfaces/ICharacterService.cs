// NosSharp
// ICharacterService.cs

using NosSharp.SDK.DTO;

namespace NosSharp.SDK.Database.Interfaces
{
    public interface ICharacterService
    {
        void Add(CharacterDto dto);
        void Add(CharacterDto[] dtos);

        void Update(CharacterDto dto);
        void Update(CharacterDto[] dto);

        CharacterDto GetById(int id);
        CharacterDto GetByName(string name);

        CharacterDto[] GetByAccountId(int id);
        CharacterDto[] GetByAccountName(string name);
        CharacterDto[] GetByAccountNameAndSlot(string name, byte? slot);

        CharacterDto[] GetTop();
        CharacterDto[] GetTop(int limitNumber);
    }
}