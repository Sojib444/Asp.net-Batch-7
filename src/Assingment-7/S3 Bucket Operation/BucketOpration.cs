using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;

namespace S3_Bucket_Operation
{
    public class BucketOpration
    {
        private BasicAWSCredentials Creadential(string acccesskey, string secretKey)
        {
            BasicAWSCredentials basicAWSCredentials = new BasicAWSCredentials(acccesskey, secretKey);

            return basicAWSCredentials;
        }

        public async Task UploadObject(string acccesskey, string secretKey,string bucketName,string filePath)
        {
            try
            {
                var credential = Creadential(acccesskey, secretKey);
                AmazonS3Client client = new AmazonS3Client(credential,Amazon.RegionEndpoint.APSouth1);
                var putRequest1 = new PutObjectRequest
                {
                    BucketName = bucketName,
                    FilePath = filePath,
                    ContentType = "text/plain"
                };

                PutObjectResponse response1 = await client.PutObjectAsync(putRequest1);
            }
            catch(AmazonS3Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DownloadObject(string acccesskey, string secretKey ,string bucketName,string objectName)
        {
            try
            {
                var credential = Creadential(acccesskey, secretKey);

                AmazonS3Client client = new AmazonS3Client(credential, Amazon.RegionEndpoint.APSouth1);

                GetObjectRequest request = new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = objectName
                };

                using GetObjectResponse response =  client.GetObjectAsync(request).Result;
                {
                    using (Stream responseStream =  response.ResponseStream)
                    {
                        using (FileStream fileStream = new FileStream("/Download.txt", FileMode.Create))
                        {
                            responseStream.CopyTo(fileStream);
                        }
                    }
                }

            }
            catch (AmazonS3Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task DeleteObject(string acccesskey, string secretKey, string bucketName, string objectName)
        {
            try
            {
                var credential = Creadential(acccesskey, secretKey);

                AmazonS3Client client = new AmazonS3Client(credential, Amazon.RegionEndpoint.APSouth1);

                DeleteObjectRequest request = new DeleteObjectRequest
                {
                    BucketName = bucketName,
                    Key = objectName
                };

                Console.WriteLine("Deleting an object");

                await client.DeleteObjectAsync(request);
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
