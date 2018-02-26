// NosSharp
// AccountModel.cs

using ServiceStack.DataAnnotations;

namespace NosSharp.SDK.Database.Models
{
    public class AccountModel
    {
        [PrimaryKey]
        [AutoIncrement]
        [Index]
        public int Id { get; set; }
    }
}