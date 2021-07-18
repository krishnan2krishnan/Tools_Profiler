using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UART_Profiler
{
    class Utility
    {
        public static void CreateBreakPoint()
        {

        }

    }

    class GetObjectTest
    {
        private const string bucketName = "<s3_bucket>";
        private const string keyName = "<keyname>";
        private const string keyID = "<keyid>";
        // Specify your bucket region (an example region is shown).
        private static readonly RegionEndpoint bucketRegion = RegionEndpoint.USWest2;
        private static IAmazonS3 client;

        public static void GetFile()
        {
            client = new AmazonS3Client(bucketRegion);
            ReadObjectDataAsync().Wait();
        }

        static async Task ReadObjectDataAsync()
        {
            string responseBody = "";
            try
            {
                GetObjectRequest request = new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = keyName
                };
                using (GetObjectResponse response = await client.GetObjectAsync(request))
                using (Stream responseStream = response.ResponseStream)
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    string title = response.Metadata["x-amz-meta-title"]; // Assume you have "title" as medata added to the object.
                    string contentType = response.Headers["Content-Type"];
                    Console.WriteLine("Object metadata, Title: {0}", title);
                    Console.WriteLine("Content type: {0}", contentType);

                    responseBody = reader.ReadToEnd(); // Now you process the response body.
                }
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered ***. Message:'{0}' when writing an object", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
            }
        }
    }

    public class UploadToS3
    {
        private const string bucketName = "<s3_bucket>";
        private const string bucketKey = "<bucket_folder>";
        private const string keyName = "<keyname>";
        private const string keyID = "<keyid>";
        
        // Specify your bucket region (an example region is shown).
        private static readonly RegionEndpoint bucketRegion = RegionEndpoint.USWest2;
        private static IAmazonS3 s3Client;

        public static void Upload(string filePath)
        {
            //string awsAccessKeyId, string awsSecretAccessKey,
            s3Client = new AmazonS3Client(awsAccessKeyId: keyID,awsSecretAccessKey:keyName, region: bucketRegion);
            UploadFile(filePath);
        }

        private static void UploadFile(string filePath)
        {
            try
            {
                //string awsAccessKeyId, string awsSecretAccessKey,
                var fileTransferUtility =
                    new TransferUtility(s3Client);

                var filetoUploadKey = bucketKey + "_" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ".csv";
                // Option 1. Upload a file. The file name is used as the object key name.
                fileTransferUtility.Upload(filePath, bucketName, key: filetoUploadKey);
                MessageBox.Show("Upload file complete..");

                //// Option 2. Specify object key name explicitly.
                //await fileTransferUtility.UploadAsync(filePath, bucketName, keyName);
                //Console.WriteLine("Upload 2 completed");

                //// Option 3. Upload data from a type of System.IO.Stream.
                //using (var fileToUpload =
                //    new FileStream(filePath, FileMode.Open, FileAccess.Read))
                //{
                //    await fileTransferUtility.UploadAsync(fileToUpload,
                //                               bucketName, keyName);
                //}
                //Console.WriteLine("Upload 3 completed");

                //// Option 4. Specify advanced settings.
                //var fileTransferUtilityRequest = new TransferUtilityUploadRequest
                //{
                //    BucketName = bucketName,
                //    FilePath = filePath,
                //    StorageClass = S3StorageClass.StandardInfrequentAccess,
                //    PartSize = 6291456, // 6 MB.
                //    Key = keyName,
                //    CannedACL = S3CannedACL.PublicRead
                //};
                //fileTransferUtilityRequest.Metadata.Add("param1", "Value1");
                //fileTransferUtilityRequest.Metadata.Add("param2", "Value2");

                //await fileTransferUtility.UploadAsync(fileTransferUtilityRequest);
                //Console.WriteLine("Upload 4 completed");
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
            }

        }

        //private static async Task UploadFileAsync()
        //{
        //    try
        //    {
        //        //string awsAccessKeyId, string awsSecretAccessKey,
        //        var fileTransferUtility =
        //            new TransferUtility(s3Client);

        //        // Option 1. Upload a file. The file name is used as the object key name.
        //        await fileTransferUtility.UploadAsync(filePath, bucketName);
        //        Console.WriteLine("Upload 1 completed");

        //        // Option 2. Specify object key name explicitly.
        //        await fileTransferUtility.UploadAsync(filePath, bucketName, keyName);
        //        Console.WriteLine("Upload 2 completed");

        //        // Option 3. Upload data from a type of System.IO.Stream.
        //        using (var fileToUpload =
        //            new FileStream(filePath, FileMode.Open, FileAccess.Read))
        //        {
        //            await fileTransferUtility.UploadAsync(fileToUpload,
        //                                       bucketName, keyName);
        //        }
        //        Console.WriteLine("Upload 3 completed");

        //        // Option 4. Specify advanced settings.
        //        var fileTransferUtilityRequest = new TransferUtilityUploadRequest
        //        {
        //            BucketName = bucketName,
        //            FilePath = filePath,
        //            StorageClass = S3StorageClass.StandardInfrequentAccess,
        //            PartSize = 6291456, // 6 MB.
        //            Key = keyName,
        //            CannedACL = S3CannedACL.PublicRead
        //        };
        //        fileTransferUtilityRequest.Metadata.Add("param1", "Value1");
        //        fileTransferUtilityRequest.Metadata.Add("param2", "Value2");

        //        await fileTransferUtility.UploadAsync(fileTransferUtilityRequest);
        //        Console.WriteLine("Upload 4 completed");
        //    }
        //    catch (AmazonS3Exception e)
        //    {
        //        Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
        //    }

        //}
    }
}
