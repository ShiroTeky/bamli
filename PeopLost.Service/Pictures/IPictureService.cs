using System.Web;
using PeopLost.Core.Domain.Pictures;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
namespace PeopLost.Service.Pictures
{
    public partial interface IPictureService
    {
        /// <summary>
        /// Deletes a  image
        /// </summary>
        /// <param name="image">Picture</param>
        void Delete(Picture image);

        /// <summary>
        /// Gets a news
        /// </summary>
        /// <param name="pictureId">The picture identifier</param>
        /// <returns>Picture</returns>
        Picture GetById(Guid PictureId);


        /// <summary>
        /// Inserts a picture item
        /// </summary>
        /// <param name="news">Picture</param>
        void Insert(Picture image);

        /// <summary>
        /// Updates the picture item
        /// </summary>
        /// <param name="picture">Picture item</param>
        void Update(Picture picture);


        /// <summary>
        /// Upload the picture item
        /// </summary>
        /// <param name="picture">Picture item</param>
        Task<string> UploadToAzureStorage(Guid personGuid,HttpPostedFileBase photoToUpload);

        /// <summary>
        /// List picture
        /// </summary>
        /// <param name="picture">Picture item</param>
        List<string> GetToAzureStorage();

        /// <summary>
        /// Updates the picture item
        /// </summary>
        /// <param name="picture">Picture item</param>
       string UpdatePictureUrlToAzureStore(Guid userid);
    }
}
