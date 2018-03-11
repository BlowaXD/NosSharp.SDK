// NosSharp
// IAccountService.cs

using NosSharp.SDK.DTO;

namespace NosSharp.SDK.DAL.Interfaces
{
    public interface IAccountService
    {
        void Add(AccountDto dto);

        void Update(AccountDto dto);

        void Delete(AccountDto dto);
        void Delete(AccountDto[] dtos);

        AccountDto GetById(int id);

        AccountDto GetByName(string name);

        AccountDto GetByMail(string email);
    }
}