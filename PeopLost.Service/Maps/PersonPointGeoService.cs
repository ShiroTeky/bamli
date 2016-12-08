using PeopLost.Core.Data;
using PeopLost.Core.Domain.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using PeopLost.Dapper.Maps;

namespace PeopLost.Service.Maps
{
    public partial class PersonPointGeoService:IPersonPointGeoService
    {
        IRepository<PersonPointGeo> pointgeoRepository;
        PersonPointGeoRepository pointgeodapper = new PersonPointGeoRepository();

        public PersonPointGeoService(IRepository<PersonPointGeo> pointgeoRepository)
        {
            this.pointgeoRepository = pointgeoRepository;
        }

        /// <summary>
        /// Deletes a  PersonPointGeo
        /// </summary>
        /// <param name="PersonPointGeo">PersonPointGeo</param>
        public void Delete(PersonPointGeo PersonPointGeo)
        {
            pointgeoRepository.Delete(PersonPointGeo);
        }

        /// <summary>
        /// Gets a PersonPointGeo
        /// </summary>
        /// <param name="PersonPointGeoId">The PersonPointGeo identifier</param>
        /// <returns>PersonPointGeo</returns>
        public PersonPointGeo GetById(Guid PersonPointGeoId)
        {
            return pointgeoRepository.GetById(PersonPointGeoId);
        }

        /// <summary>
        /// Inserts a PersonPointGeo item
        /// </summary>
        /// <param name="PersonPointGeo">PersonPointGeo</param>
        public void Insert(PersonPointGeo PersonPointGeo)
        {
            pointgeoRepository.Insert(PersonPointGeo);
        }

        /// <summary>
        /// Updates the PersonPointGeo item
        /// </summary>
        /// <param name="PersonPointGeo">PersonPointGeo item</param>
        public void Update(PersonPointGeo PersonPointGeo)
        {
            pointgeoRepository.Update(PersonPointGeo);
        }

        #region Dapper Person Position / methods
        public virtual IList<PersonPointGeo> GetAll(string town)
        {
            return pointgeodapper.GetAll(town).ToList();
        }

        public virtual IList<PersonPointGeo> GetAll()
        {
            return pointgeodapper.GetAll().ToList();
        }

        public virtual IList<PersonPointGeo> GetAllbyPersonId(Guid id)
        {
            return pointgeodapper.GetAllbyPersonId(id).ToList();
        }
        #endregion
    }
}
