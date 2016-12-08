using PeopLost.Core.Domain.Administrators;
using System;


namespace PeopLost.Service.Administrators
{
    public partial interface IAdministratorService
    {
        /// <summary>
        /// Deletes a  Administrator
        /// </summary>
        /// <param name="Administrator">Administrator</param>
        void Delete(Administrator Administrator);

        /// <summary>
        /// Gets a Administrator
        /// </summary>
        /// <param name="AdministratorId">The Administrator identifier</param>
        /// <returns>Administrator</returns>
        Administrator GetById(int AdministratorId);

        /// <summary>
        /// Inserts a Administrator item
        /// </summary>
        /// <param name="Administrator">Administrator</param>
        void Insert(Administrator Administrator);

        /// <summary>
        /// Updates the Administrator item
        /// </summary>
        /// <param name="Administrator">Administrator item</param>
        void Update(Administrator Administrator);

        //Here the service for send the notification
        /// <summary>
        /// Validate Alert. Generate a Push Notification
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        bool ValidateAlert(Guid id,Boolean status);
        
    }
}
