using PeopLost.Core.Domain.Comments;
using PeopLost.Core.Domain.Alertes;
using System.Collections.Generic;
using System.Linq;
using System;
using PeopLost.Dapper;

namespace PeopLost.Service.Alertes
{
    public partial interface IAlertService
    {

        /// <summary>
        /// Deletes a  Alert
        /// </summary>
        /// <param name="Alert">Alert</param>
        void Delete(Alert Alert);

        /// <summary>
        /// Gets a Alert
        /// </summary>
        /// <param name="AlertId">The Alert identifier</param>
        /// <returns>Alert</returns>
        Alert GetById(Guid AlertId);

        /// <summary>
        /// Inserts a Alert item
        /// </summary>
        /// <param name="Alert">Alert</param>
        void Insert(Alert Alert);

        /// <summary>
        /// Updates the Alert item
        /// </summary>
        /// <param name="Alert">Alert item</param>
        void Update(Alert Alert);

        #region Alert interface methods

        /// <summary>
        /// Gets Alert by Country
        /// </summary>
        /// <param name="country"></param>
        IList<Alert> GetAll(string contry);

        /// <summary>
        /// Gets all people
        /// </summary>
        IList<Alert> GetAll();

        /// <summary>
        /// Gets all comments of the alert 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IList<CommentUtils> GetCommentAlertbyId(Guid id);

        /// <summary>
        /// Gets all alerts of the persons/members 
        /// </summary>
        /// <returns></returns>
        IList<AlertUtils> GetAllAlertsPersons();

        /// <summary>
        /// Gets all alerts of the persons/members Concrete
        /// </summary>
        /// <returns></returns>
        IList<AlertUtils> GetAllAlertsPersonsConcrete();

        /// <summary>
        /// Gets alert of the person/member 
        /// </summary>
        /// <returns></returns>
        AlertUtils GetAlertPerson(Guid id);

        #endregion
    
    }
}