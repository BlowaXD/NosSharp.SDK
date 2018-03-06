// NosSharp.SDK
// IFamilyService.cs

using System;
using System.Collections.Generic;
using NosSharp.SDK.DTO;

namespace NosSharp.SDK.DAL.Interfaces
{
    /// <summary>
    /// Interface the families interaction
    /// </summary>
    public interface IFamilyService
    {
        /// <summary>
        /// Add a family
        /// </summary>
        /// <param name="dto"></param>
        void Add(FamilyDto dto);

        /// <summary>
        /// Store all families given in parameter
        /// </summary>
        /// <param name="dtos"></param>
        void Add(FamilyDto[] dtos);

        /// <summary>
        /// Store all families given in parameter
        /// </summary>
        /// <param name="dtos"></param>
        void Add(IEnumerable<FamilyDto> dtos);

        /// <summary>
        /// Update the familyDto which is stored in the service
        /// </summary>
        /// <param name="dto"></param>
        void Update(FamilyDto dto);

        /// <summary>
        /// Update all the familyDtos which are stored in the service
        /// </summary>
        /// <param name="dtos"></param>
        void Update(FamilyDto[] dtos);

        /// <summary>
        /// Update all the familyDtos which are stored in the service
        /// </summary>
        /// <param name="dtos"></param>
        void Update(IEnumerable<FamilyDto> dtos);


        /// <summary>
        /// Remove a Family where object has the same id as the one given in parameters
        /// </summary>
        /// <param name="dto"></param>
        void Remove(FamilyDto dto);

        /// <summary>
        /// Remove all families given in parameters
        /// </summary>
        /// <param name="dtos"></param>
        void Remove(FamilyDto[] dtos);

        /// <summary>
        /// Remove all families given in parameters
        /// </summary>
        /// <param name="dtos"></param>
        void Remove(IEnumerable<FamilyDto> dtos);

        /// <summary>
        /// Remove a family by its Id
        /// </summary>
        /// <param name="id"></param>
        void Remove(Guid id);

        /// <summary>
        /// Remove all families with their respective ids
        /// </summary>
        /// <param name="ids"></param>
        void Remove(Guid[] ids);

        /// <summary>
        /// Remove all families with their respective ids
        /// </summary>
        /// <param name="ids"></param>
        void Remove(IEnumerable<Guid> ids);

        /// <summary>
        /// Get a Family by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        FamilyDto GetById(Guid id);

        /// <summary>
        /// Get Top 10 based on their xp
        /// </summary>
        /// <returns>Top 10</returns>
        IEnumerable<FamilyDto> GetTop();

        /// <summary>
        /// Get top X based on families XP
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        IEnumerable<FamilyDto> GetTop(int max);
    }
}