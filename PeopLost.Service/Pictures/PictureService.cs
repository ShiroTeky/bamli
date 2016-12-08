using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using PeopLost.Core.Data;
using PeopLost.Core.Domain.Pictures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Web;

namespace PeopLost.Service.Pictures
{
    public partial class PictureService: IPictureService
    {
        IRepository<Picture> pictureRepository;

        public PictureService(IRepository<Picture> pictureRepository)
        {
            this.pictureRepository = pictureRepository;
        }

        public virtual void Delete(Picture image)
        {
            pictureRepository.Delete(image);
        }

        public virtual Picture GetById(Guid PictureId)
        {
            return pictureRepository.GetById(PictureId);
        }

        public virtual void Insert(Picture image)
        {
            pictureRepository.Insert(image);
        }

        public virtual void Update(Picture picture)
        {
            pictureRepository.Update(picture);
        }

        public async Task<string> UploadToAzureStorage(Guid personGuid, HttpPostedFileBase photoToUpload)
        {
            //if (photoToUpload == null || photoToUpload.ContentLength == 0)
            //{
            //    return null;
            //}
            string fullPath = null;
            Stopwatch timespan = Stopwatch.StartNew();

            // Create a unique name for the images we are about to upload 
            string imageName = personGuid.ToString();

            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve a reference to a container.
            CloudBlobContainer container = blobClient.GetContainerReference("photospeoplost");

            // Create the container if it doesn't already exist.
            container.CreateIfNotExists();

            container.SetPermissions(
            new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });


            // Create or overwrite the "photos" blob with contents from a local file.@"path\myfile"
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(imageName);
            blockBlob.Properties.ContentType = Path.GetExtension(photoToUpload.FileName);
            await blockBlob.UploadFromStreamAsync(photoToUpload.InputStream);
            fullPath = blockBlob.Uri.ToString();
            
            return fullPath;
            
        }


        public List<string> GetToAzureStorage()
        {
            List<string> partiallist = new List<string>();

            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve a reference to a container.
            CloudBlobContainer container = blobClient.GetContainerReference("photospeoplost");

            //Active your Azure Account to get access to these resources
            // Create the container if it doesn't already exist.
            //container.CreateIfNotExists();

            //container.SetPermissions(
            //new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });


            // Create or overwrite the "photos" blob with contents from a local file.@"path\myfile"
            var Listofblobs = container.ListBlobs().Take(5);
            foreach (IListBlobItem item in Listofblobs)
            {
                CloudBlockBlob blob = (CloudBlockBlob)item;
                string temp = string.Format("{0}", blob.Uri);
                partiallist.Add(temp);
            } 
            return partiallist;
        }

        public string UpdatePictureUrlToAzureStore(Guid userid)
        {

            //if (photoToUpload == null || photoToUpload.ContentLength == 0)
            //{
            //    return null;
            //}
            string fullPath = null;
            string imageName = userid.ToString();
            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve a reference to a container.
            CloudBlobContainer container = blobClient.GetContainerReference("photospeoplost");


            // Create or overwrite the "photos" blob with contents from a local file.@"path\myfile"
             CloudBlockBlob blockBlob = container.GetBlockBlobReference(imageName);
            
            fullPath = string.Format("{0}{1}",blockBlob.Uri.ToString(),blockBlob.Properties.ContentType);

            return fullPath;
        }
    
    
    }
}
