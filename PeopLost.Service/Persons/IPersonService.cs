
using PeopLost.Core.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace PeopLost.Service.Persons
{
    public partial interface IPersonService
    {
        /// <summary>
        /// Deletes a  person
        /// </summary>
        /// <param name="person">Person</param>
        void Delete(Person person);

        /// <summary>
        /// Gets a news
        /// </summary>
        /// <param name="PersonId">The Person identifier</param>
        /// <returns>Person</returns>
        Person GetById(Guid PersonId);

        /// <summary>
        /// Inserts a Person item
        /// </summary>
        /// <param name="news">Person</param>
        void Insert(Person person);

        /// <summary>
        /// Updates the Person item
        /// </summary>
        /// <param name="Person">Person item</param>
        void Update(Person Person);


        #region Person interface methods

        /// <summary>
        /// Gets People by Country
        /// </summary>
        /// <param name="country"></param>
        IList<Person> GetAll(string contry);

        /// <summary>
        /// Gets all people
        /// </summary>
        IList<Person> GetAll();

        /// <summary>
        /// Gets all alerts of the persons/members 
        /// </summary>
        /// <returns></returns>
        IList<PeopLost.Dapper.AlertUtils> GetMyAlertsPersons(Guid id);

        #endregion

    }
}
