// NosSharp.SDK
// IAlgorithmService.cs

using NosSharp.SDK.Enums.Character;
using NosSharp.SDK.Enums.Inventory.Items;

namespace NosSharp.SDK.DAL.Interfaces
{
    /// <summary>
    /// IAlgorithmService should provide the methods to recover some algorithm based datas of the game such as Xp, JobXp...
    /// </summary>
    public interface IAlgorithmService
    {
        /// <summary>
        /// This method will search through algorithm service and return the LevelXp stat based on <see cref="ClassType"/> and level
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetLevelXp(ClassType type, int level);

        /// <summary>
        /// This method will search through algorithm service and return the JobLevelXp stat based on <see cref="ClassType"/> and level
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetJobLevelXp(ClassType type, int level);

        /// <summary>
        /// This method will search through algorithm service and return the HeroLevelXp stat based on <see cref="ClassType"/> and level
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetHeroLevelXp(ClassType type, int level);

        /// <summary>
        /// This method will search through algorithm service and return the SpLevelXp stat based on <see cref="SpType"/> and level
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetSpLevelXp(SpType type, int level);

        /// <summary>
        /// This method will search through algorithm service and return the Fairy Level Xp stat based on the fairy's level
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetFairyLevelXp(int level);

        /// <summary>
        /// This method will search through algorithm service and return the Fairy Level Xp stat based on the fairy's level
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetFamilyLevelXp(int level);

        /// <summary>
        /// This method will search through algorithm service and return the Speed stat based on <see cref="ClassType"/> and level
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetSpeed(ClassType type, int level);

        /// <summary>
        /// This method will search through algorithm service and return the Close Defence stat based on <see cref="ClassType"/> and level
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetDefenceClose(ClassType type, int level);

        /// <summary>
        /// This method will search through algorithm service and return the Ranged Defence stat based on <see cref="ClassType"/> and level
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetDefenceRange(ClassType type, int level);

        /// <summary>
        /// This method will search through algorithm service and return the Magic Defence stat
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetDefenceMagic(ClassType type, int level);

        /// <summary>
        /// This method will search through algorithm service and return the Dodge close stat based on <see cref="ClassType"/> and level
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetDodgeClose(ClassType type, int level);

        /// <summary>
        /// This method will search through algorithm service and return the Dodge Ranged stat based on <see cref="ClassType"/> and level
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetDodgeRanged(ClassType type, int level);

        /// <summary>
        /// This method will search through algorithm service and return the Dodge Magic stat based on <see cref="ClassType"/> and level
        /// /!\ Should return the highest value under level if level is out of range
        /// /!\/!\ Even if the base game logic tells magic attack does not miss, you can customise this :)
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetDodgeMagic(ClassType type, int level);

        /// <summary>
        /// This method will search through algorithm service and return the minimum attack range stat based on <see cref="ClassType"/> and level
        /// /!\ Should return the highest value under level if level is out of range
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int GetMinimumAttackRange(ClassType type, int level);
    }
}