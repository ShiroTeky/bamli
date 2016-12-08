using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;
using System.Diagnostics; // Namespace for Blob storage types

namespace PeopLost.Service.BlobStorage
{
    class BlobService
    {
        public string SaveBlob(HttpPostedFileBase photoToUpload)
        {

            if (photoToUpload == null || photoToUpload.ContentLength == 0)
            {
                return null;
            }
            string fullPath = null;
            Stopwatch timespan = Stopwatch.StartNew();

            // Create a unique name for the images we are about to upload 
            string imageName = String.Format("task-photo-{0}{1}",
                Guid.NewGuid().ToString(),
                Path.GetExtension(photoToUpload.FileName)); 

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
            blockBlob.Properties.ContentType = photoToUpload.ContentType;
            blockBlob.UploadFromStreamAsync(photoToUpload.InputStream); 
            //blockBlob.UploadFromStream(fileStream);
            fullPath = blockBlob.Uri.ToString();

            return fullPath;
            
        }

        public void ListBlob()
        {// Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve reference to a previously created container.
            CloudBlobContainer container = blobClient.GetContainerReference("photos");

            // Loop over items within the container and output the length and URI.
            foreach (IListBlobItem item in container.ListBlobs(null, false))
            {
                if (item.GetType() == typeof(CloudBlockBlob))
                {
                    CloudBlockBlob blob = (CloudBlockBlob)item;

                    Console.WriteLine("Block blob of length {0}: {1}", blob.Properties.Length, blob.Uri);

                }
                else if (item.GetType() == typeof(CloudPageBlob))
                {
                    CloudPageBlob pageBlob = (CloudPageBlob)item;

                    Console.WriteLine("Page blob of length {0}: {1}", pageBlob.Properties.Length, pageBlob.Uri);

                }
                else if (item.GetType() == typeof(CloudBlobDirectory))
                {
                    CloudBlobDirectory directory = (CloudBlobDirectory)item;

                    Console.WriteLine("Directory: {0}", directory.Uri);
                }
            }

        }
    }
}
