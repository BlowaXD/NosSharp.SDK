// NosSharp
// AuthorityType.cs

namespace NosSharp.SDK.Enums
{
    public enum AuthorityType : short
    {
        Banned = -2,
        WaitingForConfirmation = -1,
        User = 0,
        Support = 50,
        GameMaster = 100,
        Admin = 1000,
    }
}