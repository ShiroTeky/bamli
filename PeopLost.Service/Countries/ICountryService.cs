
using PeopLost.Core.Domain.Countries;
using System;
using System.Collections.Generic;


namespace PeopLost.Service.Countries
{
    public partial interface ICountryService
    {
        /// <summary>
        /// Deletes a  Counttry
        /// </summary>
        /// <param name="Country">Country</param>
        void Delete(Country Country);

        /// <summary>
        /// Gets a Country
        /// </summary>
        /// <param name="CountryId">The Country identifier</param>
        /// <returns>Country</returns>
        Country GetById(Guid CountryId);

        /// <summary>
        /// Gets a Country
        /// </summary>
        /// <param name="Countries">The Country identifier</param>
        /// <returns>Country</returns>
        IList<Country> GetAll();


        /// <summary>
        /// Inserts a Country item
        /// </summary>
        /// <param name="Country">Country</param>
       void Insert(Country Country);

        /// <summary>
        /// Updates the Country item
        /// </summary>
        /// <param name="Country">Country item</param>
        void Update(Country Country);
    }
}
