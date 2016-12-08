
using PeopLost.Core.Domain.Towns;
using System;
using System.Collections.Generic;


namespace PeopLost.Service.Towns
{
    public partial interface ITownService
    {
        /// <summary>
        /// Deletes a  Counttry
        /// </summary>
        /// <param name="Town">Town</param>
        void Delete(Town Town);

        /// <summary>
        /// Gets a Town
        /// </summary>
        /// <param name="TownId">The Town identifier</param>
        /// <returns>Town</returns>
        Town GetById(Guid TownId);

        /// <summary>
        /// Gets a Town
        /// </summary>
        /// <param name="Countries">The Town identifier</param>
        /// <returns>Town</returns>
        IList<Town> GetAll();


        /// <summary>
        /// Inserts a Town item
        /// </summary>
        /// <param name="Town">Town</param>
       void Insert(Town Town);

        /// <summary>
        /// Updates the Town item
        /// </summary>
        /// <param name="Town">Town item</param>
        void Update(Town Town);
    }
}
