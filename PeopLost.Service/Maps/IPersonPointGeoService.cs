using System.Collections;
using PeopLost.Core.Domain.Maps;
using System.Collections.Generic;
using System;
namespace PeopLost.Service.Maps
{
    public partial interface IPersonPointGeoService
    {
        /// <summary>
        /// Deletes a  PersonPointGeo
        /// </summary>
        /// <param name="PersonPointGeo">PersonPointGeo</param>
        void Delete(PersonPointGeo PersonPointGeo);

        /// <summary>
        /// Gets a PersonPointGeo
        /// </summary>
        /// <param name="PersonPointGeoId">The PersonPointGeo identifier</param>
        /// <returns>PersonPointGeo</returns>
        PersonPointGeo GetById(Guid PersonPointGeoId);

        /// <summary>
        /// Inserts a PersonPointGeo item
        /// </summary>
        /// <param name="PersonPointGeo">PersonPointGeo</param>
        void Insert(PersonPointGeo PersonPointGeo);

        /// <summary>
        /// Updates the PersonPointGeo item
        /// </summary>
        /// <param name="PersonPointGeo">PersonPointGeo item</param>
        void Update(PersonPointGeo PersonPointGeo);


        #region Person Position interface methods

        /// <summary>
        /// Gets People by Country
        /// </summary>
        /// <param name="country"></param>
        IList<PersonPointGeo> GetAll(string town);

        /// <summary>
        /// Gets all people
        /// </summary>
        IList<PersonPointGeo>  GetAll();

        /// <summary>
        /// Gets all GeoLocation by Person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IList<PersonPointGeo> GetAllbyPersonId(Guid id);

        #endregion
    }
}
