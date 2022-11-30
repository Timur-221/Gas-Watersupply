using Microsoft.AspNetCore.Components.Forms;
using MongoDB.Driver.GridFS;
using MongoDB.Driver;

namespace Gas_Watersupply.Data
{
    public class FileSystemService
    {
        public  void UploadImageToDb(IBrowserFile file)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("User");
            var gridFS = new GridFSBucket(database);
        

            using (Stream stream = file.OpenReadStream())
            {
                gridFS.UploadFromStreamAsync(file.Name, stream);
            }

              

        }


        public void DownloadToLocal()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("User");
            var gridFS = new GridFSBucket(database);
            using (FileStream fs = new FileStream($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Images/")}DeserializedBall.jpg", FileMode.CreateNew))
            {
                gridFS.DownloadToStreamByName("sss.jpg", fs);
            }
        }

    }
}
