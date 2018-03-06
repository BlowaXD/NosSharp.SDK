// NosSharp.SDK
// IAlgorithmService.cs

namespace NosSharp.SDK.DAL.Interfaces
{
    public interface IAlgorithmService
    {
        int GetLevelXp(int level);
        int GetJobLevelXp(int level);
        int GetHeroLevelXp(int level);
    }
}